using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    // Configuration Parameters
    [SerializeField] AudioClip breakSound;

    private void OnCollisionEnter2D(Collision2D collision) {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        // Prints the object that collides with the block
        //Debug.Log(collision.gameObject.name); 
    }

}
