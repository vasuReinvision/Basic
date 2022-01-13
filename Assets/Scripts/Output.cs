using UnityEngine;

public class Output : MonoBehaviour
{
    void Start()
    {
        BaseStruct baseStruct = new BaseStruct(1, 33, "John");
        Debug.Log(baseStruct.GetStats());
        BaseStruct bstr = BaseStruct.GetRandomCharacter("Guard");
        Debug.Log(bstr.GetStats());
    }
}
