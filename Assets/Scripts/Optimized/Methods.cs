using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public int goldAmount;
    // Start is called before the first frame update
    void Start()
    {
        MethodEg methodEg = new MethodEg();
        methodEg.Talk();

        methodEg.SetGold(goldAmount);
        Debug.Log(methodEg.GetGold());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
