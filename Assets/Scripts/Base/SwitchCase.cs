using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    
    void Start()
    {
        
    }

 

    private void OnDisable()
    {
        string greetings = "both";
        switch (greetings)
        {
            case "hi":
            case "hello":
                Debug.Log("You're arriving");
                if(greetings == "both")
                {
                    goto case "goodbye";
                }
                break;

            case "goodbye":
                Debug.Log("You're leaving");
                break;

            case "both":
                goto case "hello";
            default:
                Debug.Log("Default msg");
                break;
                
        }
    }
}
