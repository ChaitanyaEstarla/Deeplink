using System;
using UnityEngine;

public class DeepLinkManager : MonoBehaviour
{
    public static DeepLinkManager Instance { get; private set; }
    public string deeplinkURL;

    private void Start()
    {
        Invoke(nameof(CheckDeeplink), 1f);
    }

    private void OnDeepLinkActivated(string url)
    {
        // Update DeepLink Manager global variable, so URL can be accessed from anywhere.
        deeplinkURL = url;
        
        // Decode the URL to determine action. 
        var panelName = deeplinkURL.Split("?"[0])[1];

        if (panelName == "shop")
        {
            Main.OnOnURLCall();
        }
    }

    private void CheckDeeplink()
    {
        if (Instance == null)
        {
            Instance = this;                
            //Application.deepLinkActivated += OnDeepLinkActivated;
            if (!string.IsNullOrEmpty(Application.absoluteURL))
            {
                // Cold start and Application.absoluteURL not null so process Deep Link.
                OnDeepLinkActivated(Application.absoluteURL);
            }
            // Initialize DeepLink Manager global variable.
            else
            {
                //OnDeepLinkActivated(deeplinkURL);
            }
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {   
            OnDeepLinkActivated(Application.absoluteURL);
        }
        
    }
}
