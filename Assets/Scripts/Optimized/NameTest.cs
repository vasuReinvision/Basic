using UnityEngine;

public class NameTest : MonoBehaviour
{
    private PropertyPerson propertyPerson;

    void Start()
    {
        propertyPerson = new PropertyPerson();
    }

    private void OnDisable()
    {
        propertyPerson.firstName = "Kun";
        propertyPerson.lastname = "di";
        Debug.Log(propertyPerson.fullname);
    }
}
