using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    // Configuration parameters
    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    public void CountBreakableBlocks() {
        breakableBlocks++;
    }
}
