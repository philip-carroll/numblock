using Assets.Scripts.Utils;
using UnityEngine;

public class LeftTextureController : NavigationController
{
    void Start()
    {
        this.direction = "Left";

        float width = Screen.width / 6;
        float height = width;

        //guiTexture.pixelInset = new Rect(
        //    Screen.width / 20,
        //    (Screen.height / 2) - (height / 2),
        //    width,
        //    height);
    }
}
