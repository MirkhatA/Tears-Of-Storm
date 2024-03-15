using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int targetFrame = 120;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrame;
    }

    private void Update()
    {
        if (Application.targetFrameRate != targetFrame)
        {
            Application.targetFrameRate = targetFrame;
        }
    }
}
