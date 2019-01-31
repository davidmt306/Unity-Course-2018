using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadStartManu () {
        SceneManager.LoadScene(0);
    }

    public void LoadGame () {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver () {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame () {
        Application.Quit();
    }
}
