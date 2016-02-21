using UnityEngine;

public class OperationController : MonoBehaviour
{
    public string value;
    public int operationSelectedIndex = 0;

    [SerializeField]
    private Sprite multiplication;
    [SerializeField]
    private Sprite division;
    [SerializeField]
    private Sprite addition;
    [SerializeField]
    private Sprite subtraction;

    public Transform goodSoundAudioSource;
    public Transform badSoundAudioSource;
    private AudioSource goodSound;
    private AudioSource badSound;

    void Start()
    {
        goodSound = goodSoundAudioSource.GetComponent<AudioSource>();
        badSound = badSoundAudioSource.GetComponent<AudioSource>();
        value = GameController.selectedOperations[operationSelectedIndex];
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        switch (value)
        {
            case "Addition":
                sr.sprite = addition;
                break;
            case "Subtraction":
                sr.sprite = subtraction;
                break;
            case "Division":
                sr.sprite = division;
                break;
            case "Multiplication":
                sr.sprite = multiplication;
                break;
            default:
                break;
        }
    }

    void OnMouseDown()
    {
        if (GameController.nextOperation == GameController.EMPTY_OPERATION_TEXT)
        {
            GameController.nextOperation = value;
            Destroy(gameObject);
            goodSound.Play();
        }
        else
        {
            badSound.Play();
        }
    }
}
