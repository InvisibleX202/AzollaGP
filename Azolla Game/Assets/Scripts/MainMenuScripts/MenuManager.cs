using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void ChangeSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ExitGame()
    {
        Debug.Log("Application Exited");
        Application.Quit();
    }
}
