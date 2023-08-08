using System;
using System.Dynamic;

public class Test
{
    static void Main()
    {
        dynamic d = new Duck();
        d.Quack();              // Quack 메서드가 호출되었음
        d.Waddle();             // Waddle 메서드가 호출되었음
    }
}

public class Duck : DynamicObject
{
    public override bool TryInvokeMember (
        InvokeMemberBinder binder, object[] args, out object result)
    {
        Console.WriteLine(binder.Name + " 메서드가 호출되었음");
        result = null;
        return true;
    }
}