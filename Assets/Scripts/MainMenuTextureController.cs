using Assets.Scripts.Utils;
using UnityEngine;

public class MainMenuTextureController : TextureController
{
    void Start()
    {
        this.scene = "numblock_start";

        float width = Screen.width / 2;
        float height = width / 5;

        guiTexture.pixelInset = new Rect(
            (Screen.width / 2) - (width / 2),
            (Screen.height / 2) - (height * 1.7f),
            width,
            height);
    }
}
