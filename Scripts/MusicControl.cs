using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    private void Update()
    {
        if (AudioControl.isPlay && GlobalProject.Instance.a == 0 && GlobalProject.Instance.b == 0 && GlobalProject.Instance.c == 0)
            this.GetComponent<OVRPlayerController>().Acceleration = 0;
        else
            this.GetComponent<OVRPlayerController>().Acceleration = 0.05f;
    }
}

