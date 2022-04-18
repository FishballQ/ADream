using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDancer : MonoBehaviour
{


    public void Update()
    {
        this.transform.Rotate(Vector3.up *40* Time.deltaTime);

    }
}
