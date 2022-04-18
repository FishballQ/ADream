using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject); 
    }
    void Update()
    {
        DestroyCondition();
    }
    void DestroyCondition()
    {
        if (this.transform.position.x > 100 || this.transform.position.z > 100 || this.transform.position.x < -100 || this.transform.position.z < -100)
            Destroy(this.gameObject);
    }
}
