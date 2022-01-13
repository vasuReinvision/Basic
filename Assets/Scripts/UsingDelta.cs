using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Basics
{
    public class UsingDelta : MonoBehaviour
    {
        public float speed = 10f;
        public float countDown = 10.0f;

        // Update is called once per frame
        void Update()
        {
            countDown -= Time.deltaTime;
            if (countDown <= 0.0f)
            {
                GetComponent<Light>().enabled = true;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
