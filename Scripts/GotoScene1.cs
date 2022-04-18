using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoScene1 : MonoBehaviour
{
    static public bool isHolding1 = false;
    public int a;
    private void Start()
    {
        isHolding1 = false;
        a = GlobalProject.Instance.a;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            isHolding1 = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door") && isHolding1)
        {
            SceneManager.LoadScene(01);
            a = 1;
            SavaData();
            isHolding1 = false;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            isHolding1 = false;
    }

    public void SavaData()
    {
        GlobalProject.Instance.a = a;
    }
}
