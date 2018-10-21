using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    // Configuration Parameters
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparklesVFX;
    [SerializeField] int maxHits;

    // Cached reference
    Level level;

    // State variables
    [SerializeField] int timesHit; // TODO only serialized for debug purposes

    private void Start() {
        CountBreakableBlocks();
    }

    private void CountBreakableBlocks() {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable") {
            level.CountBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (tag == "Breakable") {
            HandleHit();
        }
        // Prints the object that collides with the block
        // Debug.Log(collision.gameObject.name); 
    }

    private void HandleHit() {
        timesHit++;
        if (timesHit >= maxHits) {
            DestroyBlock();
        }
    }

    private void DestroyBlock() {
        PlayBlockDestroySFX();
        Destroy(gameObject);
        level.BlockDestroyed();
        TriggerSparklesVFX();   
    }

    private void PlayBlockDestroySFX() {
        FindObjectOfType<GameSession>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
    }

    private void TriggerSparklesVFX() {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }
}
