﻿using Assets.Scripts.Utils;
using UnityEngine;

public class LeftTextureController : NavigationController
{
    void Start()
    {
        this.direction = "Left";

        float width = Screen.width / 6;
        float height = width;

        button.rectTransform.localPosition = new Vector2(-width * 2.25f, 0);
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
