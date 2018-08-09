using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene() {
        // Variable que almacena el index de la escena actual
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Carga la escena siguiente, sumando 1 al index actual
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene() {
        SceneManager.LoadScene(0);
        Debug.Log("YES");
    }
}
