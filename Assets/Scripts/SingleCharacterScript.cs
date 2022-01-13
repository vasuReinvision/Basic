using System;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int _bullets, int _grenades, int _rockets)
        {
            bullets = _bullets;
            grenades = _grenades;
            rockets = _rockets;
        }
    }

    public Stuff myStuff = new Stuff(10, 20, 30);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefrab;
    public Transform firePosition;
    public float bulletSpeed;

    void Update()
    {
        Movement();
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefrab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;

        }

        if (Input.GetButton("Fire1") && myStuff.bullets < 0)
        {
            Debug.Log("Out of bullets");
        }
    }

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

}
