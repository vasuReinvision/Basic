using UnityEngine;

public struct BaseStruct 
{
    private int id { get; set; }
    public float strength { get; set; }
    public string name;

    public BaseStruct(int _id, float _strength, string _name)
    {
        this.id = _id;
        this.strength = _strength;
        this.name = _name;
    }

    private BaseStruct(string _name)
    {
        this.id = 2;
        this.strength = Random.Range(0, 19);
        this.name = _name;
    }

    public static BaseStruct GetRandomCharacter(string _name)
    {
        return new BaseStruct(_name);
    }

    public string GetStats()
    {
        string stats = "";
        stats += "ID : " + this.id + " , ";
        stats += "Name : " + this.name + " , ";
        stats += "Strength : " + this.strength + " ";
        return stats;
    }
}
