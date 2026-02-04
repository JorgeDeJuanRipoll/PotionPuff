using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
	// Estos métodos se asignan a los botones desde el Inspector

	public void PlayAgain()
	{
		SceneManager.LoadScene("MainMenu");
	}

}
