using UnityEngine;

public class NumberSpawner : MonoBehaviour
{
    public GameObject dropNumberPrefab;

    //private Color[] blockColours = new Color[5] { Color.red, Color.magenta, Color.green, Color.blue, Color.yellow };

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        // Instantiate a random number.
        Instantiate(dropNumberPrefab);
        //GameObject dropNum = (GameObject)Instantiate(dropNumberPrefab);
        //dropNum.renderer.material.color = blockColours[Random.Range(blockColours.GetLowerBound(0), blockColours.GetUpperBound(0))];
    }
}
