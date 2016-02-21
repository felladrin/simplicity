using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPreviousSceneButton : MonoBehaviour
{
    public void onClick()
    {
        GameController.GenerateNumbers();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
