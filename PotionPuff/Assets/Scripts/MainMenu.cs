using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoMenu : MonoBehaviour
{
	// Estos métodos se asignan a los botones desde el Inspector

	public void Play()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void ControlsH()
	{
		SceneManager.LoadScene("How to play");
	}

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}
}
