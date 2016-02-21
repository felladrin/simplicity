using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour {
	public RectTransform text;
	public RectTransform star1;
	public RectTransform star2;
	public RectTransform star3;

	public Sprite[] star1TextSprites;
	public Sprite[] star2TextSprites;
	public Sprite[] star3TextSprites;
	public Sprite[] starSprites;

	public Sprite faieldTextSprite;
	public Sprite faieldStarSprite;

	void Start () {
		Image textImage = text.GetComponent<Image> ();
		Image star1Image = star1.GetComponent<Image> ();
		Image star2Image = star2.GetComponent<Image> ();
		Image star3Image = star3.GetComponent<Image> ();

		int stageSelected = (GameController.currentStage - 1) / 3;

		bool stageFailed = (GameController.yourNumber != GameController.targetNumber);

		if (stageFailed)
		{
			textImage.sprite = faieldTextSprite;
			star1Image.sprite = faieldStarSprite;
			star2Image.sprite = faieldStarSprite;
			star3Image.sprite = faieldStarSprite;

			star2.gameObject.SetActive(true);
			star3.gameObject.SetActive(true);

            GameController.GenerateNumbers();

            Invoke("RestartStage", 3);
        }
		else
		{
			int diffInSeconds = (int)(System.DateTime.Now - GameController.stageStartTime).TotalSeconds;
			int starsDeserved = 1;
			
			if (diffInSeconds < 20)
			{
				starsDeserved = 3;
			}
			else if (diffInSeconds < 40)
			{
				starsDeserved = 2;
			}

			star1Image.sprite = starSprites[stageSelected];
			star2Image.sprite = starSprites[stageSelected];
			star3Image.sprite = starSprites[stageSelected];
			
			switch (starsDeserved) {
			case 1:
			default:
				textImage.sprite = star1TextSprites[stageSelected];
				star2.gameObject.SetActive(false);
				star3.gameObject.SetActive(false);
				break;
			case 2:
				textImage.sprite = star2TextSprites[stageSelected];
				star2.gameObject.SetActive(true);
				star3.gameObject.SetActive(false);
				break;
			case 3:
				textImage.sprite = star3TextSprites[stageSelected];
				star2.gameObject.SetActive(true);
				star3.gameObject.SetActive(true);
				break;
			}

            if (GameController.currentStage < 9)
            {
                GameController.currentStage++;
                GameController.GenerateNumbers();
                Invoke("ShowMap", 3);
            }
            else
            {
                GameController.currentStage = 1;
                Invoke("ShowGameEnding", 3);
            }
        }
    }

	void ShowMap() {
        SceneManager.LoadScene("Map");
	}

    void RestartStage()
    {
        SceneManager.LoadScene("GamePlay");
    }

    void ShowGameEnding()
    {
        SceneManager.LoadScene("GameEnding");
    }
}
