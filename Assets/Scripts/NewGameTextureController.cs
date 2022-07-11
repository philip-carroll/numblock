﻿using Assets.Scripts.Utils;
using UnityEngine;

public class NewGameTextureController : TextureController
{
    void Start()
    {
        this.scene = "numblock_scene";

        float width = Screen.width / 2;
        float height = width / 4;

        button.rectTransform.localPosition = new Vector2(0, -(height / 4));
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
