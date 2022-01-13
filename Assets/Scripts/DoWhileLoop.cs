using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    bool shouldContinue = false;
    void Update()
    {
        do
        {
            print("Should continue");
        }
        while (shouldContinue == true);
    }
}
