using UnityEngine;

public class RaiseEmployee
{
    public virtual string Speak()
    {
        return "Hi im Raise Empl";
    }
}

public class Mick : RaiseEmployee
{
    public override string Speak()
    {
        return base.Speak() + "\n Hi im mick";
    }
}
