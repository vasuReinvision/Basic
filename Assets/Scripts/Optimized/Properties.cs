using UnityEngine;

struct Badboy
{
    private int _pointValue;
    public int bonus;
    public int pointValue 
    { get
        {
            return _pointValue + bonus;
        }
        set
        {
            if(value > 0)
            {
                _pointValue = value;
            }
            else
            {
                _pointValue = 0;
            }
            Debug.Log("did set");
        }
    }
}
public class Properties : MonoBehaviour
{
    private void OnDisable()
    {
        Badboy badboy = new Badboy();
        badboy.pointValue = 111;
        Debug.Log("Badboy value is : " + badboy.pointValue);
    }
}
