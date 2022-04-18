using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalProject : MonoBehaviour
{

    public static GlobalProject Instance;

    public int a;
    public int b;
    public int c;

    private void Awake()
    {
         if(Instance==null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
         else if(Instance!=null)
        {
            Destroy(gameObject);
        }
    }
}
