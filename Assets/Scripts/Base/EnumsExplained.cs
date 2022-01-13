 using UnityEngine;

public class EnumsExplained : MonoBehaviour
{
    public enum Direction { Up = 1, Down = -1}
    public Direction playerMovement;

    public enum Numbers { One = 1, two, three, four, five, six}
    public Numbers numbers;

    string[] players = { "R", "J", "K" };
    int[] scores = { 10, 20, 30 };


    void Start()
    {
        //const float pi = 3.1419f;
        //float yMovement = 10.0f;
        //yMovement *= (int)playerMovement;
        
     /*   if(numbers == Numbers.One)
        {
            Debug.Log(11 * 11);
        }*/

        for(int i = 0; i < 3; i++)
        {
            Debug.Log(players[i] + " Scored : " + scores[i]);
        }
       
    }

    private void Update()
    {
    /*    float yMovement = 10.0f;
        yMovement *= (int)playerMovement;
        Debug.Log(yMovement);

        if (playerMovement == Direction.Down)
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }*/
    }

}
