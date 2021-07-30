using UnityEngine;

public class HelpTextTextureController : MonoBehaviour
{
    void Start()
    {
        float width = Screen.width * 0.9f;
        float height = width / 2;

        guiTexture.pixelInset = new Rect(
            (Screen.width / 2) - (width / 2),
            (Screen.height / 2) - (height / 2),
            width,
            height);
    }
}
