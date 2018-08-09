using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] int max, min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
	}
    // Inicia el juego, pone los valores iniciales
    void StartGame () {
        NextGuess();
    }
    // Cuando el valor es mas alto, min toma el valor de guess
    public void OnPressHigher() {
        min = guess + 1;
        NextGuess();
    }
    // Cuando el valor es mas bajo, max toma el valor de guess
    public void OnPressLower() {
        max = guess - 1;
        NextGuess();
    }
    // Realiza otra adivinanza dividiendo a la mitad
    void NextGuess () {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1); // Random el numero que va a adivinar al comienzo del juego, rango min - max
        guessText.text = guess.ToString(); // Convertimos el numero a string para colocar el texto.
    }
}
