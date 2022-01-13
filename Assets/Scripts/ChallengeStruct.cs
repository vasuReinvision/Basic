using UnityEngine;

public struct ChallengeStruct
{
    private string spell;
    private int damage;
    private float areaOfDamage;

    public ChallengeStruct(string _spell, int _dmg, float _areaofdmg)
    {
        spell = _spell;
        damage = _dmg;
        areaOfDamage = _areaofdmg;
    }

    public ChallengeStruct(string _spell)
    {
        spell = _spell;
        damage = 10;
        areaOfDamage = 1.0f;
    }

    public ChallengeStruct(string _spell, int _dmg)
    {
        spell = _spell;
        damage = _dmg;
        areaOfDamage = 1.0f;
    }

    public string GetStats()
    {
        string stats = "";
        stats += "Name of the Spell : " + spell + " , ";
        stats += " Damage : " + damage + " , ";
        stats += "Area of Damage : " + areaOfDamage + " ";
        return stats;
    }

}
