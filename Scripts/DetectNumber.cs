using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectNumber : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject light;
    public OVRCameraRig CameraRig;
    void Start()
    {
        if (GlobalProject.Instance.a == 1)
        {
            a.SetActive(true);
            b.SetActive(true);
        }
        if(GlobalProject.Instance.b == 1)
        {
            c.SetActive(true);
            d.SetActive(true);
        }
        if(GlobalProject.Instance.c == 1)
        {
            e.SetActive(true);
            f.SetActive(true);
        }
        if (GlobalProject.Instance.a + GlobalProject.Instance.b + GlobalProject.Instance.c == 3)
            light.SetActive(true);
    }

    void Update()
    {
        if (TestPuzzle1.count1 == 3 && TestPuzzle2.count2 == 2 && TestPuzzle3.count3 == 1 
            && TestPuzzle4.count4 == 3 && TestPuzzle5.count5 == 3 && TestPuzzle6.count6 == 2)
        {
            FrostEffect a = CameraRig.centerEyeAnchor.GetComponent<FrostEffect>();
            a.FrostAmount += 0.1f * Time.deltaTime;
            Invoke("LoadEnd", 5f);
        }
    }
    void LoadEnd()
    {
        SceneManager.LoadScene(4);
    }
}
