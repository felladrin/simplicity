using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController
{
	public const string EMPTY_OPERATION_TEXT = "- Select -";

	public static bool isPaused = false;
    public static bool musicIsPlaying = false;
    public static int currentStage = 1;
	public static System.DateTime stageStartTime;

    public static int yourNumber = 0;
	public static string nextOperation = EMPTY_OPERATION_TEXT;
	public static int targetNumber;
	
	private static string[] operations = new string[] {"Multiplication", "Division", "Addition", "Subtraction"};
	private static int[] numbers = new int[] {1,2,3,4,5,6,7,8,9};
	
	public static string[] selectedOperations;
	public static int[] selectedNumbers;

	private static int calculationsMade = 0;
	
	public static void Calculate(int number)
	{
		switch (nextOperation)
		{
		case "Addition":
			yourNumber += number;
			break;
		case "Subtraction":
			yourNumber -= number;
			break;
		case "Division":
			if (number != 0)
				yourNumber /= number;
			break;
		case "Multiplication":
			yourNumber *= number;
			break;
		default:
			break;
		}
		
		if (yourNumber < 0)
			yourNumber = 0;

		if (++calculationsMade == 3) {
			calculationsMade = 0;
			ShowResultScene();
		}
	}

	public static void ShowResultScene()
	{
        SceneManager.LoadScene("Result");
	}

	public static void GenerateNumbers()
	{
		stageStartTime = System.DateTime.Now;

		int maximumNumber = (currentStage * 10) + 20;
		int startingNumber;
		float result;

		do
		{
			selectedOperations = new string[3];
			selectedNumbers = new int[3];
			
			startingNumber = Random.Range((int)maximumNumber/2, maximumNumber);
			result = startingNumber;
			
			for (int i = 0; i < 3; i++)
			{
				string randomOperation = operations[Random.Range(0, operations.Length)];
				int randomNumber = numbers[Random.Range(0, numbers.Length)];
				
				selectedOperations[i] = randomOperation;
				selectedNumbers[i] = randomNumber;
				
				switch(randomOperation)
				{
				case "Multiplication":
					result *= randomNumber;
					break;
				case "Division":
					result /= randomNumber;
					break;
				case "Addition":
					result += randomNumber;
					break;
				case "Subtraction":
					result -= randomNumber;
					break;
				}
				
				if (result != (int)result)
				{
					break;
				}
			}
		}
		while(
			result != (int)result
			|| (selectedOperations[0] == selectedOperations[1]) && (selectedOperations[1] == selectedOperations[2])
			|| (int)result == startingNumber
			|| (int)result < 0
			|| (int)result > maximumNumber
		);

		targetNumber = (int)result;
		yourNumber = startingNumber;
	}

	public static void ClearNextOperationText()
	{
		nextOperation = EMPTY_OPERATION_TEXT;
	}
}
