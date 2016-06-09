using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public string startLevel;
	public string highScores;

	public GameObject highScoresScreen;
	public GameObject MainMenuScreen;
    public GameObject GameScene;

    public int Main_scene { get; private set; }

    public void startGame()
	{
		
	}

	public void instructionsGame()
	{
		highScoresScreen.SetActive (true);
		MainMenuScreen.SetActive (false);
	}

	public void quitGame()
	{
		Debug.Log ("Game Exited");
		Application.Quit ();

	}

	public void ReturnGame()
	{
		highScoresScreen.SetActive (false);
		MainMenuScreen.SetActive (true);
	}

   
    
}
