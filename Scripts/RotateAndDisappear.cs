using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndDisappear : MonoBehaviour
{
    private GameObject player;
    public DestroyBubbles bubbles;
    private bool isApproach = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
        IfApproaching();
    }

    void IfApproaching()
    {
        if (player.transform.position.x-this.transform.position.x < 5 && player.transform.position.z-this.transform.position.z < 6 &&
            player.transform.position.x-this.transform.position.x > -5 && player.transform.position.z - this.transform.position.z > -6)
        {
            transform.Rotate(Vector3.up * 40 * Time.deltaTime);
            this.transform.Translate(Vector3.up * 0.5f * Time.deltaTime);
            Bubble();
        }
    }
    void Bubble()
    {
        if (!isApproach)
            return;

        DestroyBubbles _spawnedBubles = Instantiate(bubbles, this.transform.position, Quaternion.identity);
        _spawnedBubles.transform.Translate(Vector3.up * 40 * Time.deltaTime);
        isApproach=false;
    }

}
