using System;

class Test
{
    static int Calc(int x) => 10 / x;

    static void Main()
    {
        try
        {
            int y = Calc(0);
            Console.WriteLine(y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("x가 0이면 안 됨");
        }
        Console.WriteLine("프로그램 실행 완료");
    }
}