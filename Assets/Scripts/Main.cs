using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void Play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(2);
    }


    public void Options()
    {
        //TODO
    }


    public void Quit()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
