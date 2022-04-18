using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicBox : MonoBehaviour
{
    public GameObject musicD;
    private bool isTriggered;

    private void Update()
    {
        this.musicD.transform.Rotate(Vector3.up * 20 * Time.deltaTime);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;
        musicD.SetActive(true);
        AudioControl.audioSource[6].SetActive(true);
        if (!AudioControl.audioSource[6].GetComponent<AudioSource>().isPlaying)
            AudioControl.audioSource[12].SetActive(true);

    }
    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;
        isTriggered = true;

    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;
        if (isTriggered)
            return;

    }
    private void OnCollisionEnter(Collision collision)
    {
        musicD.SetActive(false);
    }

}
