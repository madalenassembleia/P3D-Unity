﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {

    public void QuitTheGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
