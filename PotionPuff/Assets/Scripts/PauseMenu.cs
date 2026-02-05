using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPausa;
   

    public void Pausar()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time .timeScale = 1;
        menuPausa.SetActive(false);
    }

    public void VolverMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }
 
}
