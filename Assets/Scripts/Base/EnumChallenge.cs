using UnityEngine;

public class EnumChallenge : MonoBehaviour
{
    public enum DaysofTheWeek { Monday = 1, Tuesday, Wednesday, Thu, Fri, Sat, Sun}
    public DaysofTheWeek currDay;
    
    void Start()
    {
        switch (currDay)
        {
            case DaysofTheWeek.Monday:
                Debug.Log("You can fallapart");
                break;

            case DaysofTheWeek.Tuesday:
            case DaysofTheWeek.Wednesday:
                Debug.Log("Break my hrttt");
                break;

            case DaysofTheWeek.Thu:
                Debug.Log("Doesnt even start");
                break;

            case DaysofTheWeek.Fri:
                Debug.Log("In love");
                break;

            case DaysofTheWeek.Sat:
                Debug.Log("Wait");
                break;

            case DaysofTheWeek.Sun:
                Debug.Log("Always late");
                break;
        }
    }
}
