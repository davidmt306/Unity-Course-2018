using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
        // Prints the object that collides with the block
        //Debug.Log(collision.gameObject.name); 
    }

}
