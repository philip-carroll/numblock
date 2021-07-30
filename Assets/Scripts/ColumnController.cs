using UnityEngine;

public class ColumnController : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite lockedSprite;

    public int hitCount;
    public bool locked;

    void Start()
    {
        hitCount = 0;
        locked = false;
    }

    public void Lock()
    {
        locked = true;
        gameObject.GetComponent<SpriteRenderer>().sprite = lockedSprite;
    }

    public void Unlock()
    {
        locked = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = normalSprite;
    }
}
