using Assets.Scripts.Utils;
using UnityEngine;

public class ExitTextureController : TextureController
{
    void Start()
    {
        this.scene = "exit";

        float width = Screen.width / 2;
        float height = width / 4;

        guiTexture.pixelInset = new Rect(
            (Screen.width / 2) - (width / 2),
            (Screen.height / 3) - height,
            width,
            height);
    }
}
