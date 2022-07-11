using Assets.Scripts.Utils;
using UnityEngine;

public class MainMenuTextureController : TextureController
{
    void Start()
    {
        this.scene = "numblock_start";

        float width = Screen.width / 2;
        float height = width / 5;

        button.rectTransform.localPosition = new Vector2(0, -height);
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
