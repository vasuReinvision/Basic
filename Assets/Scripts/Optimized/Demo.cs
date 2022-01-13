using UnityEngine;

public class Demo : MonoBehaviour
{
    private void OnDisable()
    {
        WaterEnemy water = new WaterEnemy();
        water.TakeDamage(10, Enemyzz.DamageType.Fire);
        Debug.Log(water.GetHitPoints());

        FireEnemy fire = new FireEnemy();
        fire.TakeDamage(12, Enemyzz.DamageType.Fire);
        Debug.Log(fire.GetHitPoints());
    }

}
