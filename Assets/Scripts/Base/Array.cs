using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public int[] arr = new int[3];
    int[] arr2 = { 1, 2, 3, 4, 5, 6 };

    // Start is called before the first frame update
    void Start()
    {
        arr[0] = Random.Range(0, 100);
        /*Debug.Log(arr2.Length);
        Debug.Log(arr2[3]);
        Debug.Log(sizeof(int));
*/
        /*        for (int i = 0; i < arr.Length; i++)
                {
                    Debug.Log(arr[i]);
                }*/

        arr[1] = Random.Range(1, 44);
        arr[2] = Random.Range(1, 100);
        /*arr[3] = Random.Range(1, 100);
        arr[4] = Random.Range(1, 100);*/

        /*Debug.Log(arr.Length);*/

        /*        for(int i = 0; i < arr.Length; i++)
                {
                    Debug.Log(arr[i]);
                }*/

        string result;
        result = (arr[0] % 2 == 0) ? "even" : "odd";
        Debug.Log(arr[0] + " is " + result);

        result = (arr[1] % 2 == 0) ? "even" : "odd";
        Debug.Log(arr[1] + " is " + result);

        result = (arr[2] % 2 == 0) ? "even" : "odd";
        Debug.Log(arr[2] + " is " + result);




    }
}
