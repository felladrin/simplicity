using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSpecificSceneButton : MonoBehaviour
{
    public string SceneNameOrId;

    public void onClick()
    {
        GameController.GenerateNumbers();

        int sceneId;

        if (int.TryParse(SceneNameOrId, out sceneId))
        {
            SceneManager.LoadScene(sceneId);
        }
        else
        {
            SceneManager.LoadScene(SceneNameOrId);
        }
        
    }
}
