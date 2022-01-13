using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBreaker : MonoBehaviour
{
    
    void Start()
    {
        ChallengeStruct iceBall = new ChallengeStruct("IceBreaker");
        Debug.Log(iceBall.GetStats());

        ChallengeStruct fireball = new ChallengeStruct("FireBall", 100);
        Debug.Log(fireball.GetStats());

        ChallengeStruct eartthQuake = new ChallengeStruct("EarthQuake", 10, 100.0f);
        Debug.Log(eartthQuake.GetStats());
    }
}
