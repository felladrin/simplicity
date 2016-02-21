using UnityEngine;
using UnityEngine.UI;

public class GlowingButton : MonoBehaviour
{
    public float speed = 2;
    private Text text;
    float r, g, b;

    void Start()
    {
        text = GetComponent<Text>();
        r = text.color.r;
        g = text.color.g;
        b = text.color.b;
    }

    void Update()
    {
        Color newColor = new Color(r, g, b, Mathf.PingPong(Time.time * speed, 1));
        text.color = newColor;
    }
}