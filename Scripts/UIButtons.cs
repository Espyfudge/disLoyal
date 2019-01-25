using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public string startGame;
    public string nextScreen;
	public string additiveScreen;

    public void NewGame()
    {
		SceneManager.LoadScene(startGame, LoadSceneMode.Single);
    }

    public void NextScreen()
    {
        SceneManager.LoadScene(nextScreen, LoadSceneMode.Single);
    }

	public void addedScreen() {
		gameObject.SetActive (false);
		SceneManager.LoadScene (additiveScreen, LoadSceneMode.Additive);
	}

    public void QuitGame()
    {
        Application.Quit();
    }
}
