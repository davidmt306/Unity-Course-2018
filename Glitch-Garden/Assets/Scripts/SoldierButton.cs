using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierButton : MonoBehaviour {

    private void OnMouseDown() {
        var buttons = FindObjectsOfType<SoldierButton>();
        foreach(SoldierButton button in buttons) {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255); 
        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
