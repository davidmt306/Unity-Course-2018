using UnityEngine;
using UnityEngine.UI;
using Vdopia;

public class AdTest : MonoBehaviour {

    private const string ApiKey = "k2m3Co";

    VdopiaPlugin plugin;

    public void Initialize() 
    {
        Debug.Log("Initialize...");
        if(Application.platform == RuntimePlatform.Android) 
        {
            plugin = VdopiaPlugin.GetInstance(); // Initialize Plugin Instance

            if(plugin != null) 
            {
                VdopiaListener.GetInstance().VdopiaAdDelegateEventHandler += OnVdopiaEventReceiver;
            } 
            else 
            {
                Debug.Log("Vdopia Plugin Initialize Error.");
            }
        }
    }

    void OnVdopiaEventReceiver(string adType, string eventName) // Ad Event Receiver
    {
        Debug.Log("Ad Event Received: " + eventName + " : for Ad Type : " + adType);
    }

    // ========== Interstitial Ad Methods ==========

    public void LoadInterstitial() // Called when Load Interstitial button clicked
    {
        Debug.Log("Load Interstitial...");
        if (Application.platform == RuntimePlatform.Android) 
        {
            plugin.LoadInterstitialAd(ApiKey);
        }
    }

    public void ShowInterstitial() // Called when Show Interstitial button clicked
    {
        Debug.Log("Show Interstitial...");
        if (Application.platform == RuntimePlatform.Android && plugin != null)
        {
            // Make sure Interstitial Ad is loaded before call this method
            plugin.ShowInterstitialAd();

            // Optional: prefetch the next Interstitial Ad without making any callbacks
            plugin.PrefetchInterstitialAd(ApiKey);
        }
    }

    // ========== Rewarded Ad Methods ==========

    public void RequestReward() // Called when Request Reward button clicked
    {
        Debug.Log("Request Reward...");
        if (Application.platform == RuntimePlatform.Android && plugin != null)
        {
            plugin.RequestRewardAd(ApiKey);
        }
    }

    public void ShowReward() 
    {
        Debug.Log("Show Rewarded...");
        if(Application.platform == RuntimePlatform.Android && plugin != null) 
        {
            // Make sure Reward Ad is loaded before call this method
            plugin.ShowRewardAd("qj5ebyZ0F0vzW6yg", "Chocolate1", "life", "1");

            // Optional: prefetch the next Rewarded Ad without making any callbacks
            plugin.PrefetchRewardAd(ApiKey);
        }
    }

    public void CheckRewardAdAvailable() 
    {
        Debug.Log("Check Reward Ad Available...");
        if (Application.platform == RuntimePlatform.Android && plugin != null) 
        {
            bool isReady = plugin.IsRewardAdAvailableToShow();
            Debug.Log("Check Reward Ad Available... " + isReady);
        }
    }
}
