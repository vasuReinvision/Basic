using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassEg : MonoBehaviour
{
    List<Minion> minions;
    // Start is called before the first frame update
    void Start()
    {
        minions = new List<Minion>();
        minions.Add(new Minion("Kevin"));
        minions.Add(new Minion("Kowoloski"));
        minions.Add(new Minion("Ted"));
        minions.Add(new Minion("Phil"));
    }

    void OnDisable()
    {
        minions = null;
    }
}
