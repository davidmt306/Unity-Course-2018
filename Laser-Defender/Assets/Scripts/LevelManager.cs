﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    // Configuration parameters
    [SerializeField] float delayInSeconds = 2f;

    public void LoadStartManu () {
        SceneManager.LoadScene(0);
    }

    public void LoadGame () {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver () {
        StartCoroutine(WaitAndLoad());
        
    }

    IEnumerator WaitAndLoad () {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame () {
        Application.Quit();
    }
}
