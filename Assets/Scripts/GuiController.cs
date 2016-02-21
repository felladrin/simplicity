using UnityEngine;
using UnityEngine.UI;

public class GuiController : MonoBehaviour
{
    [SerializeField]
    private RectTransform CurrentStage;

    [SerializeField]
    private RectTransform YourNumber;

    [SerializeField]
    private RectTransform NextOperation;

    [SerializeField]
    private RectTransform TargetNumber;

    private Text CurrentStageText;
    private Text YourNumberText;
    private Text NextOperationText;
    private Text TargetNumberText;

    void Start()
    {
        CurrentStageText = CurrentStage.GetComponent<Text>();
        YourNumberText = YourNumber.GetComponent<Text>();
        NextOperationText = NextOperation.GetComponent<Text>();
        TargetNumberText = TargetNumber.GetComponent<Text>();
    }

    void Update()
    {
        CurrentStageText.text = GameController.currentStage.ToString();
        YourNumberText.text = GameController.yourNumber.ToString();
        NextOperationText.text = GameController.nextOperation;
        TargetNumberText.text = GameController.targetNumber.ToString();
    }
}
