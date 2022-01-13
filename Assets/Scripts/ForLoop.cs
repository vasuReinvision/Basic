using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int enemies = 4;

    void Start()
    {
        for (int i = 0; i < enemies; i++)
        {
            Debug.Log("Creating enemy number : " + i);

        }
    }
}
