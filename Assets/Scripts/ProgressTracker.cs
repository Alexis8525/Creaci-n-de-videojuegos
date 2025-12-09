using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressTracker : MonoBehaviour
{
    private static ProgressTracker instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string sceneName = scene.name;

        bool esNivel = sceneName.StartsWith("Nivel");              // Nivel1, Nivel2, Nivel3...
        bool esMenuNivel = sceneName.StartsWith("MenuANivel");    // MenuANivel2, MenuANivel3...
        bool esMenuFinal = sceneName == "MenuFinal";

        if (esNivel || esMenuNivel || esMenuFinal)
        {
            SaveSystem.SaveProgress(sceneName);
            Debug.Log("💾 Progreso guardado automáticamente en: " + sceneName);
        }
    }

    public void SaveCurrentProgress()
    {
        SaveSystem.SaveProgress(SceneManager.GetActiveScene().name);
    }
}
