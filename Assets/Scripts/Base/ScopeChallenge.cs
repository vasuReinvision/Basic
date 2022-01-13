using UnityEngine;

public class ScopeChallenge : MonoBehaviour
{
    bool shouldProceed = true;
    int additionalValue;
    void Start()
    {
        int value = 44;

        int z = 0;

        if (shouldProceed)
        {
            additionalValue = 5;
            z = 55;
        }
        Debug.Log((value + additionalValue) + " " + z);
    }

}
