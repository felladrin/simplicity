using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneButton : MonoBehaviour
{
    public void onClick()
    {
        GameController.GenerateNumbers();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
