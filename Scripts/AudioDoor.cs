using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDoor : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(GotoScene1.isHolding1)
            AudioControl.audioSource[15].SetActive(true);
        if(GotoScene2.isHolding2)
            AudioControl.audioSource[17].SetActive(true);
        if(GotoScene3.isHolding3)
            AudioControl.audioSource[16].SetActive(true);
    }
}
