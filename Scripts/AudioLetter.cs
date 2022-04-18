using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLetter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AudioControl.audioSource[13].SetActive(true);
    }
}
