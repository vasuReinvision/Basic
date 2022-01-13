using UnityEngine;

struct MethodEg
{
    private int gold;
    public void Talk()
    {
        Debug.Log("Blah blah");
    }

    public int GetGold()
    {
        return gold;
    }

    public void SetGold(int _gold)
    {
        if(_gold > 0)
        {
            this.gold = _gold;
            Debug.Log("here");
        }
    }
}

