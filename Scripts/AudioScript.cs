using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AudioControl.audioSource[14].SetActive(true);
    }
}
