using UnityEngine;
using UnityEngine.UI;

public class HelpTextTextureController : MonoBehaviour
{
    private Image button;

    void Start()
    {
        float width = Screen.width * 0.9f;
        float height = width / 2;

        button = gameObject.GetComponent<Image>();
        button.rectTransform.localPosition = new Vector2(0, 0);
        button.rectTransform.sizeDelta = new Vector2(width, height);
        //guiTexture.pixelInset = new Rect(
        //    (Screen.width / 2) - (width / 2),
        //    (Screen.height / 2) - (height / 2),
        //    width,
        //    height);
    }
}