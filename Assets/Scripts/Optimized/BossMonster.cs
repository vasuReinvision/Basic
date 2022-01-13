using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster
{
    public string name;
    public float value;


    public BossMonster(string name, int points)
    {
        this.name = name;
        this.value = points;
    }


    ~BossMonster()
    {
        Debug.Log("Boss Monste destroyed");
    }
    
}
