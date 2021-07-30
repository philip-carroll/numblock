using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Launching Numblock");

        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;

        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}
