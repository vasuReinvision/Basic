using UnityEngine;

struct MethodChallengers {
    private int health;

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int _health)
    {
        this.health = _health;
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
    }
}
