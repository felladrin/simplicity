using UnityEngine;

public class MarkerController : MonoBehaviour
{
    public int stageRequired;
    public int backgroundToAppear;

    void Start()
    {
        int backgroundSelected = (GameController.currentStage - 1) / 3;

        gameObject.SetActive((backgroundToAppear == backgroundSelected) && (GameController.currentStage > stageRequired));
    }
}
