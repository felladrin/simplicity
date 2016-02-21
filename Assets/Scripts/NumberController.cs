using UnityEngine;

public class NumberController : MonoBehaviour {
	public int value;
	public int numberSelectedIndex = 0;

	[SerializeField]
	private Sprite[] number1;
	[SerializeField]
	private Sprite[] number2;
	[SerializeField]
	private Sprite[] number3;
	[SerializeField]
	private Sprite[] number4;
	[SerializeField]
	private Sprite[] number5;
	[SerializeField]
	private Sprite[] number6;
	[SerializeField]
	private Sprite[] number7;
	[SerializeField]
	private Sprite[] number8;
	[SerializeField]
	private Sprite[] number9;

	public Transform goodSoundAudioSource;
	public Transform badSoundAudioSource;
	private AudioSource goodSound;
	private AudioSource badSound;

	void Start () {
		goodSound = goodSoundAudioSource.GetComponent<AudioSource> ();
		badSound = badSoundAudioSource.GetComponent<AudioSource> ();
		value = GameController.selectedNumbers [numberSelectedIndex];
		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer> ();
		int spriteSelected = (GameController.currentStage - 1) / 3;

		switch (value) {
			case 1:
				sr.sprite = number1[spriteSelected];
				break;
			case 2:
				sr.sprite = number2[spriteSelected];
				break;
			case 3:
				sr.sprite = number3[spriteSelected];
				break;
			case 4:
				sr.sprite = number4[spriteSelected];
				break;
			case 5:
				sr.sprite = number5[spriteSelected];
				break;
			case 6:
				sr.sprite = number6[spriteSelected];
				break;
			case 7:
				sr.sprite = number7[spriteSelected];
				break;
			case 8:
				sr.sprite = number8[spriteSelected];
				break;
			case 9:
				sr.sprite = number9[spriteSelected];
				break;
		}
	}

	void OnMouseDown()
	{
		if (GameController.nextOperation != GameController.EMPTY_OPERATION_TEXT) {
			GameController.Calculate(value);
			GameController.ClearNextOperationText();
			Destroy(gameObject);
			goodSound.Play();
		}
		else
		{
			badSound.Play();
		}
	}
}
