using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string debut;


    public void StartGame()
    {
        SceneManager.LoadScene(debut);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
