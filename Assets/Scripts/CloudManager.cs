using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CloudManager : MonoBehaviour
{
    [SerializeField] private CloudRecoBehaviour cloudRecoBehaviour;
    [SerializeField] private GameObject[] targets;
    private bool isScanning;

    private void Awake()
    {
        cloudRecoBehaviour.RegisterOnInitializedEventHandler(OnInitialized);
        cloudRecoBehaviour.RegisterOnStateChangedEventHandler(OnStateChanged);
        cloudRecoBehaviour.RegisterOnNewSearchResultEventHandler(OnNewSearchResult);
    }

    private void OnDestroy()
    {
        cloudRecoBehaviour.UnregisterOnInitializedEventHandler(OnInitialized);
        cloudRecoBehaviour.UnregisterOnStateChangedEventHandler(OnStateChanged);
        cloudRecoBehaviour.UnregisterOnNewSearchResultEventHandler(OnNewSearchResult);
    }

    private void OnInitialized(CloudRecoBehaviour cloudRecoBehaviour)
    {
        Debug.Log("Cloud initialized");
    }

    private void OnStateChanged(bool scanning)
    {
        isScanning = scanning;
        if (isScanning)
        {
            Debug.Log("Is Scanning");
        }
    }

    private void OnNewSearchResult(CloudRecoBehaviour.CloudRecoSearchResult result)
    {
        foreach (var target in targets)
        {
            if (result.TargetName == target.name) 
            {
                cloudRecoBehaviour.EnableObservers(result, target);
            }
        }
    }
}
