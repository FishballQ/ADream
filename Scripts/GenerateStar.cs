using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStar : MonoBehaviour
{
    private float a;
    private float b;
    private float c;
    public Light light;
    public Light star;

    void Start()
    {
        for(int i =0; i < 50; i++)
        {
            Generate();
        }
        for(int i = 0; i< 200; i++)
        {
            Star();
        }
    }

    void Generate()
    {
        Light l = Instantiate(light);
        a = Random.Range(-250, 250);
        b = Random.Range(-250, 250);
        c = Random.Range(10, 100);
        l.transform.position = new Vector3(a, c, b);
    }
    void Star()
    {
        Light l = Instantiate(star);
        a = Random.Range(-250, 250);
        b = Random.Range(-250, 250);
        c = Random.Range(10, 100);
        l.transform.position = new Vector3(a, c, b);
    }


}
