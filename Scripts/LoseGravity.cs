using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGravity : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;
        rb.useGravity = false;
        Destroy(this.gameObject, 5);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.collider.CompareTag("Bullet"))
            return;
        rb.useGravity = false;
        Destroy(this.gameObject, 5);
    }
}
