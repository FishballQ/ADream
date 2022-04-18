using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioThisMusic : MonoBehaviour
{
    private GameObject forget; 
    void Start()
    {
        forget = GameObject.Find("12");
        forget.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        forget.SetActive(true);
    }
}
