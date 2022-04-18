using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBubbles : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject,4);
    }
}
