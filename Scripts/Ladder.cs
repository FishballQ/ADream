
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ladder : MonoBehaviour
{
    private bool isPlayer = false;
    private float timer=5;
    private Transform ladder;
    private GameObject forget;
    private void Start()
    {
        ladder = GameObject.Find("ladder").GetComponent<Transform>();
        forget = GameObject.Find("12");
        forget.SetActive(false);
    }

    void Update()
    {
        Test();
        if (!isPlayer)
            return;
        this.GetComponent<OVRPlayerController>().Acceleration=0;
        ladder.Translate(Vector3.up * 0.5f * Time.deltaTime);
        forget.SetActive(true);
        if (this.transform.position.y >= 5)
            SceneManager.LoadScene(0);
    }
    void Test()
    {
        if (Mathf.Abs(this.transform.position.z - ladder.position.z) < 0.3f && Mathf.Abs(this.transform.position.x - ladder.position.x) < 0.3f)
            isPlayer = true;
    }

}
