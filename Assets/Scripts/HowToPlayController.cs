using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour {
	void OnMouseDown() {
        SceneManager.LoadScene("MainMenu");
	}
}
