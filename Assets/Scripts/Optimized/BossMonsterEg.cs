using UnityEngine;

public class BossMonsterEg : MonoBehaviour
{
    BossMonster bossMonster = null;
    BossMonster sameBoss = null;
    void Start()
    {
        bossMonster = new BossMonster("Halo", 33);
        sameBoss = bossMonster;
        bossMonster = null;
    }

    private void OnDisable()
    {
        sameBoss = null;
    }
}
