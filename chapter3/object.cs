using System;

public class Stack
{
    int position;
    object[] data = new object[10];
    public void Push(object obj) { data[position++] = obj; }
    public object Pop() { return data[--position]; }

    static void Main()
    {
        Stack stack = new Stack();
        stack.Push("sausage");
        string s = (string)stack.Pop();                         // 하향 캐스팅으로 명시적 캐스팅 필요

        Console.WriteLine(s);
    }
}
