using UnityEngine;

public class BrackgroundController : MonoBehaviour {
	public Sprite[] sprites;

	void Start () {
		int backgroundSelected = (GameController.currentStage - 1) / 3;
		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = sprites [backgroundSelected];
	}
}
