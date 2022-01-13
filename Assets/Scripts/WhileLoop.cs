using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;

    private void Update()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("Washed the cup");
            cupsInTheSink--;
        }
    }
}
