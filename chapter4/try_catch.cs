using System;

class Test
{
    static void Main(string[] args)
    {
        try
        {
            byte b = byte.Parse(args[0]);
            Console.WriteLine(b);
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("인수를 적어도 하나는 지정하세요.");
        }
        catch(FormatException ex)
        {
            Console.WriteLine("수가 아닙니다!");
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("byte 하나에 담지 못할 정도로 큰 값!");
        }
    }
}