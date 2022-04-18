using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMirror : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AudioControl.audioSource[10].SetActive(true);
    }
}
