using UnityEngine;

struct PropertyPerson
{
    private string _fullName;
    public string firstName { get; set; }
    public string lastname { get; set; }
    public string fullname 
    { 
        get
        {
            return firstName + lastname;
        }
        set
        {
            fullname = _fullName;
        }
    }
}