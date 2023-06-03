using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchButton : MonoBehaviour
{
    public InputField sceneNameInput;

    //Nomaina ainu pec nosaukuma
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    //Iziet no speles
    public void QuitGame()
    {
        Application.Quit();
    }
}