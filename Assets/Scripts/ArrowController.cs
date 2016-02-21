using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour
{
    void Start()
    {
        switch(GameController.currentStage)
        {
            case 1:
            default:
                transform.position = new Vector3(0.25F, -4.17F, 0);
                break;
            case 2:
                transform.position = new Vector3(-1.61F, -0.09F, 0);
                break;
            case 3:
                transform.position = new Vector3(1.45F, 4.04F, 0);
                break;
            case 4:
                transform.position = new Vector3(-1.92F, -1.49F, 0);
                break;
            case 5:
                transform.position = new Vector3(1.37F, 1.41F, 0);
                break;
            case 6:
                transform.position = new Vector3(-1.48F, 3.68F, 0);
                break;
            case 7:
                transform.position = new Vector3(1.38F, -4.25F, 0);
                break;
            case 8:
                transform.position = new Vector3(-1.71F, -1.54F, 0);
                break;
            case 9:
                transform.position = new Vector3(1.53F, 0.85F, 0);
                break;
        }
    }
}
