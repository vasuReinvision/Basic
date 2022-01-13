using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    [SerializeField] public Rigidbody rocketPrefab;
    public Transform fireposition;
    public float bulletSpeed;
    [SerializeField] private float rocketSpeed;

    private Inventory inventory;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }

    private void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletinstance = Instantiate(bulletPrefab, fireposition.position, fireposition.rotation);
            bulletinstance.AddForce(fireposition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
            Debug.Log("bullet count after firing : " + inventory.myStuff.bullets);

        }

        if (Input.GetButtonDown("Fire2") && inventory.myStuff.rockets > 0)
        {
            Rigidbody rocketInstance = Instantiate(rocketPrefab, fireposition.position, rocketPrefab.transform.rotation);
            rocketInstance.AddForce(fireposition.forward * rocketSpeed);
            inventory.myStuff.rockets--;
        }

        
    }
}
