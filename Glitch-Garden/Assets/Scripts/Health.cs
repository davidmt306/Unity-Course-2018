using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    // Configuration parameters
    [SerializeField] float health = 100f;

    Animator animator;

    private void Start() {
        animator = gameObject.GetComponent<Animator>();
    }

    public void DealDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            animator.SetTrigger("Death"); 
        }
    }

    public void DestroyZombie() {
        Destroy(gameObject, 1f);
    }
}
