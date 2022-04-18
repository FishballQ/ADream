using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoScene2 : MonoBehaviour
{
    public static bool isHolding2 = false;
    public int b;
    private void Start()
    {
        b = GlobalProject.Instance.b;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            isHolding2 = true;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door") && isHolding2)
        {
            SceneManager.LoadScene(02);
            b = 1;
            SavaData();
            isHolding2 = false;
        }
        AudioControl.audioSource[7].SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            isHolding2 = false;
    }
    public void SavaData()
    {
        GlobalProject.Instance.b = b;
    }
}
