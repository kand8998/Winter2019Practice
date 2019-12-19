using UnityEngine;

public class ColorArray : MonoBehaviour
{
    private Color[] color = new Color[6];

    private void Start()
    {
        color[0] = Color.red;
        color[1] = Color.green;
        color[2] = Color.yellow;
        color[3] = Color.blue;
        color[4] = Color.magenta;
        color[5] = new Color(0.29f, 0f, 0.07f);
        color[6] = Color.white;
    }

    public void ColorChange()
    {
        GetComponent<SpriteRenderer>().color = color[Random.Range(0, color.Length)];
    }
}
