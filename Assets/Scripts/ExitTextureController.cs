using Assets.Scripts.Utils;
using UnityEngine;

public class ExitTextureController : TextureController
{
    void Start()
    {
        this.scene = "exit";

        float width = Screen.width / 3;
        float height = width / 4;

        button.rectTransform.localPosition = new Vector2(0, 0);
        button.rectTransform.sizeDelta = new Vector2(width, height);
        //guiTexture.pixelInset = new Rect(
        //    (Screen.width / 2) - (width / 2),
        //    (Screen.height / 3) - height,
        //    width,
        //    height);
    }
}
