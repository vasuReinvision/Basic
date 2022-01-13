using UnityEngine;

public class DoWhile : MonoBehaviour
{
    int z = 12;
    bool isaNum = false;
    /*public int[] scores;*/
    public string[] favGames;
    void Start()
    {
        /*do
        {
            Debug.Log(z * z + z);
            z--;
        }
        while (z > 5);
    }*/
        int i = 0;
        /*      while (i < scores.Length)
              {
                  Debug.Log("The " + i + " element is " + scores[i]);
                  i++;
              }*/

        /*        do
                {
                    Debug.Log("The " + i + " element is " + scores[i]);
                    i++;
                }
                while (i < scores.Length);*/

        /*    do
            {
                Debug.Log((z * z) + (z - z));
                z--;
            }
            while (z < 3);*/

        do
        {
            Debug.Log(favGames[i]);
            i++;
        }
        while (i > favGames.Length);
    }
}
