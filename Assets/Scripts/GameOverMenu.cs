using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    void OnGUI()
    {
        const int buttonWidth = 500;
        const int buttonHeight = 250;

        // Create style for a button
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 50;

        if (GUI.Button(
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight),
            "New Game",
            buttonStyle))
        {
            Application.LoadLevel("numblock_scene");
        }

        if (GUI.Button(
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight),
            "Main Menu",
            buttonStyle))
        {
            Application.LoadLevel("numblock_start");
        }
    }
}
