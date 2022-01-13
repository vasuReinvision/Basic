using UnityEngine;

public class BossAttack : MonoBehaviour
{
    private void OnDisable()
    {
        IceBoss iceBos = new IceBoss();
        FireBoss fireBoss = new FireBoss();

        iceBos.Shoot();
        fireBoss.Shoot();
    }
}
