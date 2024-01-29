using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("MainScene");

    }

     public void Exitscene()
    {
        Application.Quit();
    }

     public void LoadScene3()
    {
        SceneManager.LoadScene("");
    }
}

