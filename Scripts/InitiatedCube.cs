using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiatedCube : MonoBehaviour
{
    public Rigidbody prefabCube;
    public Transform OriginalP;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("floor"))
        {
            Destroy(this.gameObject);
            Rigidbody newCube = Instantiate(prefabCube);
            newCube.transform.position =OriginalP.position;
            newCube.transform.rotation = OriginalP.rotation;
        }
        
    }

}
