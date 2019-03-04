using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour {
    //Configuration parameters
    [SerializeField] GameObject soldier;

    private void OnMouseDown() {
        SpawnSoldier();
    }

    private void SpawnSoldier() {
        GameObject newSoldier = Instantiate(soldier, transform.position, Quaternion.identity) as GameObject;
    }
}
