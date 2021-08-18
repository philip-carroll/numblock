using Assets.Scripts.Utils;
using UnityEngine;

public class HelpTextureController : TextureController
{
    void Start()
    {
        this.scene = "numblock_help";

        float width = Screen.width / 16;
        float height = width;

        button.rectTransform.localPosition = new Vector2((Screen.width / 2) - width, width - (Screen.height / 2));
        button.rectTransform.sizeDelta = new Vector2(width, height);
        //guiTexture.pixelInset = new Rect(
        //    Screen.width - (width * 1.5f),
        //    (height * 1.5f) - height,
        //    width,
        //    height);
    }
}
