using UnityEngine;

public class Number : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprite;

    public int value;

    void Start()
    {
        value = Random.Range(0, sprite.Length);
        GetComponent<SpriteRenderer>().sprite = sprite[value];
    }

    void OnMouseDown()
    {
        GameController.Calculate(value);
        Destroy(gameObject);
    }
}
