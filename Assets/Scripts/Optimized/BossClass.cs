using UnityEngine;

public class BossClass 
{
    protected string name;
    protected string shootText;

    public void Shoot()
    {
        Debug.Log(shootText);
    }
}

public class FireBoss : BossClass
{
    public FireBoss()
    {
        name = "FireBoss";
        shootText = "FireBall";
    }
}

public class IceBoss : BossClass
{
    public IceBoss()
    {
        name = "IceBoss";
        shootText = "IceBall";
    }
}
