using System;

delegate int Transformer(int x);

class Test
{
    static void Main()
    {
        Transformer t = Square;         // 대리자 인스턴스 생성
        int result = t(3);              // 대리자 호출
        Console.WriteLine(result);      // 9
    }
    static int Square(int x) => x * x;
}
