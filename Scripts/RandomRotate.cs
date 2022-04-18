using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    private int random;
    void Start()
    {
        random = Random.Range(1, 360);
        this.transform.Rotate(Vector3.up * random);
    }

}
