using UnityEngine;

public class StaticConstructor
{
    private static int id;
    private string name { get; set; }
    private float value { get; }
    private float health { get; set; }

    public static int _id
    {
        get
        {
            return id;
        }
    }

    /*    public string _name
        {
            get
            {
                return name;
            }
        }*/

    public StaticConstructor()
    {
        Debug.Log("Calling Default constrcutor 1 = " + id);
        /*Debug.Log("Calling Default constrcutor 2 : " + id1);*/
    }

    public StaticConstructor(string _name, int _health)
    {
        this.name = _name;
        this.health = _health;
        this.value = 22.99f;
        
    }

    public StaticConstructor(string _name, float _value)
    {
        this.name = _name;
        this.value = _value;
    }

    private StaticConstructor(string _name)
    {
        id = 1;
        name = _name;
        health = Random.Range(1,100);
        value = Random.Range(10.0f, 22.2f);
        Debug.Log("Calling parameterized constructor : " + id);

    }

    public static StaticConstructor ReturnDetails(string _name)
    {
        return new StaticConstructor(_name);
    }

    public string GetConstDetails()
    {
        string res = "";
        res += "ID : " + id + " , ";
        res += "Name : " + name + " , ";
        res += "Health : " + health + " , ";
        res += "Value : " + value + " , ";
        return res;
    }


/*    public static void Print()
    {
        Debug.Log("Test id = " + id);
    }

    void Start()
    {
        StaticConstructor stat = new StaticConstructor(40, 50);
        StaticConstructor stat2 = new StaticConstructor(66, 77);

    }*/


}
