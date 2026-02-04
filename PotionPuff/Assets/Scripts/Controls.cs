using UnityEngine;
using UnityEngine.SceneManagement;

public class howtoplay : MonoBehaviour
{
	// Estos métodos se asignan a los botones desde el Inspector

	public void Return()
	{
		SceneManager.LoadScene("MainMenu");
	}

}
