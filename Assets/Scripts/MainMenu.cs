using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Launching Numblock");

        if (PlayGamesPlatform.Instance.IsAuthenticated() == false)
        {
            try
            {
                PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
            }
            catch (Exception ex)
            {
                Debug.Log("Numblock GPGS exception:" + ex.ToString());
            }
        }
        else
        {
            Debug.Log("Numblock GPGS authenticated");
        }

        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;

        Screen.orientation = ScreenOrientation.AutoRotation;

        Application.targetFrameRate = 60;
    }

    internal void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            // Continue with Play Games Services
            Debug.Log("GPGS login successful");
        }
        else
        {
            // Disable your integration with Play Games Services or show a login button
            // to ask users to sign-in. Clicking it should call
            // PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication).
            Debug.Log("GPGS login failed");
        }
    }
}
