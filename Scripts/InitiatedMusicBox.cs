using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiatedMusicBox : MonoBehaviour
{
    public MusicBox prefabCube;
    public Transform OriginalP;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("floor"))
        {
            Destroy(this.gameObject);
            Instantiate(prefabCube, OriginalP.position, OriginalP.rotation);

        }

    }
}
