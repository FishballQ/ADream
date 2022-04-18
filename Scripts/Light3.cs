using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light3 : MonoBehaviour
{
    private Light light;
    private float t;
    private void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {

        light.intensity = Mathf.PingPong(Time.time*5, 5);
        Debug.Log(light.intensity.ToString());
    }
}
