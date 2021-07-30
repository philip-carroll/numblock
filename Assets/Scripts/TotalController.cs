using UnityEngine;

public class TotalController : MonoBehaviour
{
    public GameObject dialogPrefab;
    public GameObject gameOverPrefab;
    public GameObject restartPrefab;
    public GameObject mainMenuPrefab;

    public TextMesh numberText;
    public int currentNumber;

    private bool numberChange = true;
    private int startNumber;

    void Start()
    {
        Reset();
        startNumber = currentNumber;
    }

    void Reset()
    {
        currentNumber = Random.Range(10, 20);
    }

    void Update()
    {
        if (numberChange)
        {
            numberText.text = currentNumber.ToString();
            numberChange = false;
        }
    }

    public bool Recalc(int dropNumber)
    {
        numberChange = true;

        if (dropNumber == currentNumber)
        {
            GameManager.instance.UpdateScore(startNumber);
            Reset();

            return true;
        }
        else
        {
            if (dropNumber > currentNumber)
            {
                GameManager.instance.gameOver = true;
                Time.timeScale = 0;
                GameManager.instance.SetHighscore();

                Instantiate(dialogPrefab);
                Instantiate(gameOverPrefab);
                Instantiate(restartPrefab);
                Instantiate(mainMenuPrefab);
            }
            else
                currentNumber -= dropNumber;

            return false;
        }
    }
}
