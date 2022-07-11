using Assets.Scripts.Utils;
using UnityEngine;

public class ExitTextureController : TextureController
{
    void Start()
    {
        this.scene = "exit";

        float width = Screen.width / 2;
        float height = width / 4;

        button.rectTransform.localPosition = new Vector2(0, -height);
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
