using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour {
    //Configuration parameters
    [SerializeField] GameObject soldier;

    private void OnMouseDown() {
        SpawnSoldier(GetSquareClicked());
    }

    private Vector2 GetSquareClicked () {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos) {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnSoldier(Vector2 RoundedPos) {
        GameObject newSoldier = Instantiate(soldier, RoundedPos, Quaternion.identity) as GameObject;
        newSoldier.transform.Rotate(0, -180, 0);  
    }
}
