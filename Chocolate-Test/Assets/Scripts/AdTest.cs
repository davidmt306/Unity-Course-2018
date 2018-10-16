using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vdopia;

public class AdTest : MonoBehaviour {

    VdopiaPlugin plugin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void requestRewardAd() {
        Debug.Log("Reward video requested");
        if (Application.platform == RuntimePlatform.Android && plugin != null) {
            plugin.RequestRewardAd("XqjhRR");
        }
    }
}
