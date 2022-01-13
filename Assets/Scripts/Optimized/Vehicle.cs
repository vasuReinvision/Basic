using UnityEngine;

abstract class Blah
{
    public abstract string Sound();
}

class Car : Blah
{
    /*private string carSound;

    public Car(string soound)
    {
        this.carSound = soound;
    }*/
    public override string Sound()
    {
        return "Vroom";
    }
}

class Bike : Blah
{
  /*  private string bikeSound;*/
/*    public Bike(string bksnd)
    {
        this.bikeSound = bksnd;
    }*/
    public override string Sound()
    {
        return "Burrr";
    }
}
public class Vehicle : MonoBehaviour
{
    private void OnDisable()
    {
  
        Blah[] blah = new Blah[] { new Car(), new Bike()};
        foreach(Blah bla in blah)
        {
            Debug.Log(bla.Sound());
        }

    }
}
