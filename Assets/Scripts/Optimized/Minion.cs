using UnityEngine;

public class Minion
{
    public string name;
    public Minion(string name)
    {
        Debug.Log("Calling parameterized constrcutor");
        this.name = name;
    }

    ~Minion()
    {
        Debug.Log("Calling destructor " + name);
    }
}
