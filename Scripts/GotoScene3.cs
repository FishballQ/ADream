using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoScene3 : MonoBehaviour
{
    static public bool isHolding3 = false;
    public int c;
    private void Start()
    {
        isHolding3 = false;
        c = GlobalProject.Instance.c;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            isHolding3 = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door") && isHolding3)
        {
            SceneManager.LoadScene(03); 
            c = 1;
            SavaData();
            isHolding3 = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            isHolding3 = false;
    }
    public void SavaData()
    {
        GlobalProject.Instance.c = c;
    }
}
