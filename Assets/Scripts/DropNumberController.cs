using UnityEngine;

public class DropNumberController : MonoBehaviour
{
    public enum dropNumberStates
    {
        moving = 0,
        locked
    }

    public int currentNumber;
    public dropNumberStates dropNumberState;
    public TextMesh numberText;
    public TotalController[] totalControllers;

    private float moveSpeed;

    private Vector3 currentPosition;
    private Vector3 targetPosition;
    private Vector3 moveDirection;

    private float[] channels = new float[5] { -4f, -2f, 0f, 2f, 4f };
    private int currentChannel;
    private bool changingLane;

    void Start()
    {
        currentNumber = GenerateNumber();
        numberText.text = currentNumber.ToString();

        dropNumberState = dropNumberStates.moving;

        currentChannel = 2;
        MoveDown();

        if (GameManager.instance.columns[currentChannel].GetComponent<ColumnController>().locked)
        {
            string[] directions = { "Left", "Right" };
            int randomNumber = Random.Range(0, directions.Length);
            GameManager.instance.direction = directions[randomNumber];
        }
    }

    private int GenerateNumber()
    {
        totalControllers = new TotalController[5];
        ColumnController[] columnControllers = new ColumnController[5];

        for (int i = 0; i < 5; i++)
        {
            totalControllers[i] = GameObject.FindWithTag("TotalNumber" + (i + 1)).GetComponent<TotalController>();
            columnControllers[i] = GameManager.instance.columns[i].GetComponent<ColumnController>();
        }

        bool validNumber = false;
        int tempNumber = 0;

        while (!validNumber)
        {
            tempNumber = Random.Range(1, 9);
            for (int i = 0; i < 5; i++)
            {
                if (columnControllers[i].locked)
                    continue;
                else
                    if (tempNumber > totalControllers[i].currentNumber)
                        continue;

                validNumber = true;
            }
        }

        return tempNumber;
    }

    void MoveDown()
    {
        changingLane = false;
        moveDirection = Vector3.down;
        moveSpeed = GameManager.instance.blockSpeed;
        GameManager.instance.direction = "Down";
    }

    void MoveLane()
    {
        changingLane = true;
        targetPosition.x = channels[currentChannel];
        targetPosition.y = currentPosition.y;
        targetPosition.z = currentPosition.z;
        moveSpeed = 15;
        GameManager.instance.direction = "Down";
    }

    void Update()
    {
        currentPosition = transform.position;

        if (dropNumberState == dropNumberStates.locked)
        {
            // locked within a column, only way is down
            moveDirection = Vector3.down;
        }
        else
        {
            if (GameManager.instance.direction != "Down" && !changingLane)
            {
                if (GameManager.instance.direction == "Left" && currentChannel > 0)
                {
                    // move left
                    if (!GameManager.instance.columns[currentChannel - 1].GetComponent<ColumnController>().locked)
                        currentChannel--;
                    else
                    {
                        if (currentChannel - 2 >= 0)
                            currentChannel -= 2;
                    }

                    MoveLane();
                }
                else
                {
                    if (GameManager.instance.direction == "Right" && currentChannel < 4)
                    {
                        // move right
                        if (!GameManager.instance.columns[currentChannel + 1].GetComponent<ColumnController>().locked)
                            currentChannel++;
                        else
                        {
                            if (currentChannel + 2 <= 4)
                                currentChannel += 2;
                        }

                        MoveLane();
                    }
                }
            }
        }

        if (changingLane)
        {
            if (targetPosition.x != currentPosition.x)
                transform.position = Vector3.MoveTowards(currentPosition, targetPosition, Time.deltaTime * moveSpeed);
            else
                MoveDown();
        }
        else
        {
            Vector3 targetPosition = moveDirection * moveSpeed + currentPosition;
            transform.position = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime);
        }
    }
}
