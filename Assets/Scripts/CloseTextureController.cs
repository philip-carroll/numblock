using Assets.Scripts.Utils;
using UnityEngine;

public class CloseTextureController : TextureController
{
    void Start()
    {
        this.scene = "numblock_start";

        float width = Screen.width / 16;
        float height = width;

        button.rectTransform.localPosition = new Vector2((Screen.width / 2) - width, width - (Screen.height / 2));
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}