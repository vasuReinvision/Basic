using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    string[] names = { "A", "b", "c", "d", "s", "z", "g" };
    
    void Start()
    {
        foreach(string name in names)
        {
            if(name == "c" || name == "s") 
            {
                continue;
            }
            Debug.Log(name);
        }
    }

    
}
