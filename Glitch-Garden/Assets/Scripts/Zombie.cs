using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
    // Configuration parameters
    [Range (0f, 2f)]
    [SerializeField] float walkSpeed;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
	}
}
