using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;
    public Bullet BulletPrefab;
    public OVRInput.Button ShootButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(ShootButton))
        {
            Bullet bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }

}
