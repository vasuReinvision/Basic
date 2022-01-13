using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int _bullets, int _grenades, int _rockets)
        {
            bullets = _bullets;
            grenades = _grenades;
            rockets = _rockets;
        }

        public Stuff(int _bullets, float _fuel)
        {
            bullets = _bullets;
            fuel = _fuel;
        }

        public Stuff()

        {
            bullets = 10;
            grenades = 20;
            rockets = 10;
        }

    }

    public Stuff myStuff = new Stuff(100, 30, 20);
    public Stuff myOtherStuff = new Stuff(70, 15.6f);

    private void Start()
    {
        Debug.Log("bullet count : " + myStuff.bullets);
    }

}
