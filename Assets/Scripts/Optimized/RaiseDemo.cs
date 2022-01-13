using UnityEngine;

public class RaiseDemo : MonoBehaviour
{
    private void OnDisable()
    {
        Mick mick = new Mick();
        /*mick.Speak();*/
        Debug.Log(mick.Speak());
    }
}
