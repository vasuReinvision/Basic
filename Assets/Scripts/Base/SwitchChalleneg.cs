using UnityEngine;

public class SwitchChalleneg : MonoBehaviour
{
    public int playerCount; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        switch (playerCount)
        {
            case 1:
                Debug.Log("Hello Player");
                break;

            case 2:
                Debug.Log("Hello Players");
                break;

            default:
                Debug.Log("Please select either 1 or 2 player");
                break;
        }
    }
}
