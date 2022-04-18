using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiate002 : MonoBehaviour
{
    public Transform person;
    public GameObject testPrefab;
    private int a=-4;
    void Generate()
    {
        GameObject obj = (GameObject)Instantiate(testPrefab);
        int ni = Random.Range(5, 10);
        obj.transform.position = new Vector3((int)person.position.x - ni, 0, a);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < 9; i++)
            {
                Generate();
                a++;
            }
            
            this.GetComponent<Collider>().enabled = false;
        }
    }
}
