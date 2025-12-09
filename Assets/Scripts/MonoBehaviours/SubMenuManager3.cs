using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenuManager3 : MonoBehaviour
{
    // metodo para iniciar el juego
    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel4");
    }

    // Metodo para salir del juego
    public void QuitGame()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}