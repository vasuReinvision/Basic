using UnityEngine;

public class ImplementConst : MonoBehaviour
{
   
    void Start()
    {
        StaticConstructor staticConstructor = new StaticConstructor("Joe", 33);
        Debug.Log(staticConstructor.GetConstDetails());

        StaticConstructor staticConstructor1 = new StaticConstructor("Boy", 44.4f);
        Debug.Log(staticConstructor1.GetConstDetails());

        StaticConstructor staticConstructor2 = StaticConstructor.ReturnDetails("Moster");
       
        Debug.Log(staticConstructor2.GetConstDetails());
    }

}
