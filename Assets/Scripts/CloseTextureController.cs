using Assets.Scripts.Utils;
using UnityEngine;

public class CloseTextureController : TextureController
{
    void Start()
    {
        this.scene = "numblock_start";

        float width = Screen.width / 16;
        float height = width;

        //guiTexture.pixelInset = new Rect(
        //    Screen.width - (width * 1.5f),
        //    (height * 1.5f) - height,
        //    width,
        //    height);
    }
}
