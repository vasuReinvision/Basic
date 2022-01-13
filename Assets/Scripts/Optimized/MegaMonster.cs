using UnityEngine;

public class MegaMonster : MonoBehaviour
{
    private int damage;
    public int healthValue;
    private MethodChallengers methodChallengers;

    void Start()
    {
        damage = Random.Range(1, 100);
        methodChallengers = new MethodChallengers();
        methodChallengers.SetHealth(healthValue);
    }

    private void OnDisable()
    {
        /*methodChallengers.SetHealth(methodChallengers.GetHealth() - damage);
        if (methodChallengers.GetHealth() <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Health is : " + methodChallengers.GetHealth());
        }*/
        methodChallengers.TakeDamage(damage);
        if (methodChallengers.GetHealth() < 0)
        {
            Debug.Log("Matash!!");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Health is : " + methodChallengers.GetHealth());
        }
    }
}
