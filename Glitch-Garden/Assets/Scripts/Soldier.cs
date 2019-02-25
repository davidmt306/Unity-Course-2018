using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour {
    // Configuration Parameters
    [SerializeField] GameObject projectile, bulletExit;
    public void Fire() {
        Instantiate(projectile, bulletExit.transform.position, bulletExit.transform.rotation);
    }
	
}
