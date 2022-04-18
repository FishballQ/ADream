using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastBubble : MonoBehaviour
{

    public Transform FirePoint;
    public float MaxDistance;
    public LayerMask layer;
    public DestroyBubbles bubbles;
    private RaycastHit hitinfo;

    public Camera camera;

    private void Start()
    {

    }
    /*void Start()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
        }
    }*/


    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        bool hit = Physics.Raycast(ray, out hitinfo, MaxDistance, layer);

        if (hit)
        {

            Debug.DrawLine(FirePoint.position, hitinfo.point, Color.red);
            transform.LookAt(hitinfo.point);

            Rigidbody rigidbody = hitinfo.collider.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {
                if (rigidbody.GetComponent<Rigidbody>().CompareTag("Girl3"))
                {
                    Instantiate(bubbles, hitinfo.point, Quaternion.identity);
                }
            }
            
        }
        else
        {
            Vector3 hitPoint = FirePoint.position + ray.direction * MaxDistance;
            transform.LookAt(hitPoint);
        }

    }
}
