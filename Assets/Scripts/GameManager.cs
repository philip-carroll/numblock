using GooglePlayGames;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    private int score;
    private int level;
    private int blocksCleared;
    private int levelIncrement = 3;

    public Camera mainCamera;
    public GameObject[] columns;

    public float blockSpeed;
    public TextMesh highScoreText;
    public TextMesh scoreText;
    public TextMesh levelText;

    public string direction;

    public bool gameOver;

    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = UnityEngine.Object.FindObjectOfType(typeof(GameManager)) as GameManager;
                _instance.SetUp();
            }

            return _instance;
        }
    }

    private void SetUp()
    {
        GameManager.instance.gameOver = false;
        Time.timeScale = 1;

        this.highScoreText.text = GetHighScore().ToString().PadLeft(3, '0');
        this.direction = "Down";
    }

    public void UpdateScore(int points)
    {
        this.score += points;
        scoreText.text = this.score.ToString().PadLeft(3, '0'); ;

        blocksCleared++;

        if (blocksCleared % levelIncrement == 0)
        {
            this.IncreaseLevel();

            if (this.level < 15)
            {
                foreach (GameObject col in columns)
                    col.transform.localScale += new Vector3(0, 0.05f, 0);
            }
        }
    }

    public void IncreaseLevel()
    {
        this.blockSpeed += 0.2f;
        this.level += 1;

        this.levelText.text = level.ToString().PadLeft(3, '0');
        //this.mainCamera.backgroundColor = this.mainCamera.backgroundColor - new Color(0.025f, 0.025f, 0.025f);
    }

    public void SetHighscore()
    {
        string key = "highScore";

        if (PlayerPrefs.HasKey(key))
        {
            if (PlayerPrefs.GetInt(key) <= score)
            {
                PlayerPrefs.SetInt(key, score);

                if (PlayGamesPlatform.Instance.IsAuthenticated())
                {
                    try
                    {
                        // Post score to leaderboard
                        PlayGamesPlatform.Instance.ReportScore(score, GPGSIds.leaderboard_high_scores, (bool success) =>
                        {
                            if (success)
                            {
                                Debug.Log("Numblock GPGS score posted");
                                //PlayGamesPlatform.Instance.ShowLeaderboardUI();
                            }
                            else
                                Debug.Log("Numblock GPGS score posting failure");
                        });
                    }
                    catch (Exception ex)
                    {
                        Debug.Log("Numblock GPGS score posting exception:" + ex.ToString());
                    }
                }
                else
                    Debug.Log("Numblock GPGS not authenticated");
            }
        }
        else
            PlayerPrefs.SetInt(key, score);

        PlayerPrefs.Save();
    }

    public int GetHighScore()
    {
        string key = "highScore";

        if (PlayerPrefs.HasKey(key))
            return PlayerPrefs.GetInt(key);
        else
            return 0;
    }
}
