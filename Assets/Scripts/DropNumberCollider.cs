using UnityEngine;

public class DropNumberCollider : MonoBehaviour
{
    public DropNumberController dropNumberController;

    private NumberSpawner numberSpawner;

    void Start()
    {
        if (numberSpawner == null)
            numberSpawner = GameObject.FindWithTag("NumberSpawner").GetComponent<NumberSpawner>();
    }

    void OnTriggerEnter2D(Collider2D collidedObject)
    {
        dropNumberController.dropNumberState = DropNumberController.dropNumberStates.locked;
    }

    void OnTriggerExit2D(Collider2D collidedObject)
    {
        int i = 0;

        switch (collidedObject.tag)
        {
            case "Column1":
                i = 0;
                break;
            case "Column2":
                i = 1;
                break;
            case "Column3":
                i = 2;
                break;
            case "Column4":
                i = 3;
                break;
            case "Column5":
                i = 4;
                break;
        }

        bool score = dropNumberController.totalControllers[i].Recalc(dropNumberController.currentNumber);

        // Lock this column if necessary
        ColumnController a = GameManager.instance.columns[i].GetComponent<ColumnController>();
        if (!score)
        {
            a.hitCount++;
            if (a.hitCount >= 3 && !a.locked)
                a.Lock();
        }
        else
            a.hitCount = 0;

        // Unlock the rest and reset hit count
        for (int j = 0; j < 5; j++)
        {
            if (j != i)
            {
                ColumnController b = GameManager.instance.columns[j].GetComponent<ColumnController>();
                b.hitCount = 0;
                if (b.locked)
                    b.Unlock();
            }
        }

        Destroy(this.gameObject);
        if (!GameManager.instance.gameOver)
            numberSpawner.Spawn();
    }
}
