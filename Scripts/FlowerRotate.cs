using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerRotate : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        
    }

    void Update()
    {
        if (player.position.x - transform.position.x < 5 && player.position.x - transform.position.x > -5 
            && player.position.z - transform.position.z < 5 && player.position.z - transform.position.z > -5)
        {
            //float t = Time.time / 5;
            //transform.rotation = Quaternion.Lerp(this.transform.rotation, lookAt.rotation, 1);
            //transform.LookAt(player);
            Vector3 direction = new Vector3(-player.position.x+transform.position.x,0,-player.position.z+transform.position.z);
            transform.rotation = Quaternion.LookRotation(direction);

        }

    }
}

