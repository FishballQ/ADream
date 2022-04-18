using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTestPrefab : MonoBehaviour
{
    private float timer=2;

    void Update()
    {

        DestroyThis();
    }

    void DestroyThis()
    {
        if(this.transform.position.y!=1 && this.transform.position.y!=3 && this.transform.position.z!=-4 && this.transform.position.z != 4)
            timer -= Time.deltaTime;
        if (timer > 0)
            return;

        Destroy(this.gameObject);
        
    }

}
