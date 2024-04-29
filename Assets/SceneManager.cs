using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
   
    public void Jugar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gaming");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

  
}