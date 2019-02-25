using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {
    // Configuration parameters
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Zombie zombiePrefab;
    bool spawn = true;

    IEnumerator Start() {
        while (spawn) {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnZombie();
        }
    }

    private void SpawnZombie() {
        Instantiate(zombiePrefab, transform.transform.position, transform.rotation);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
