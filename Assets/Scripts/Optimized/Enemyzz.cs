public class Enemyzz
{
    protected int hitPoints;
    public enum DamageType { Water, Fire};

    public virtual void TakeDamage(int amount, DamageType damageType)
    {
        hitPoints -= amount;
    }

    public string GetHitPoints()
    {
        return "Taking damage : " + hitPoints;
    }
}

public class WaterEnemy : Enemyzz
{
    public WaterEnemy()
    {
        hitPoints = 30;
    }
    public override void TakeDamage(int amount, DamageType damageType)
    {
        if (damageType == DamageType.Fire)
        {
            base.TakeDamage(amount * 2, damageType);
        }
        else
        {
            base.TakeDamage(amount / 2, damageType);
        }
    }
}

public class FireEnemy : Enemyzz
{
    public FireEnemy()
    {
        hitPoints = 42;
    }
    public override void TakeDamage(int amount, DamageType damageType)
    {
        if (damageType == DamageType.Water)
        {
            base.TakeDamage(amount * 10, DamageType.Fire);
        }
        else
        {
            base.TakeDamage(amount + 2, damageType);
        }

    }
}
