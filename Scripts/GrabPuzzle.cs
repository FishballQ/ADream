using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabPuzzle : MonoBehaviour
{
    private GameObject[] s;
    void Start()
    {
        s = GameObject.FindGameObjectsWithTag("Puzzles");

    }

    // Update is called once per frame
    void Update()
    {
    }

    void Test()
    {
        foreach (object temp in s)
            Debug.Log("this is"+ temp.ToString());
        /*for(int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
                if (s[i].transform.position.x == s[j].transform.position.x)
                    
        }*/
    }
    private void OnTriggerStay(Collider other)
    {
        //if (other.CompareTag("Player"))
            //this.GetComponent<BoxCollider>().isTrigger = false;
    }
}
