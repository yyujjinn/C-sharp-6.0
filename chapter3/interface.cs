using System;

interface I1 { void Foo(); }
interface I2 { int Foo(); }

class Test
{
    public class Widget : I1, I2
    {
        public void Foo()
        {
            Console.WriteLine("Widget의 I1.Foo 구현");

        }

        int I2.Foo()
        {
            Console.WriteLine("Widget의 I2.Foo 구현");
            return 42;
        }
    }

    static void Main()
    {
        Widget w = new Widget();
        w.Foo();                    // Widget I1.Foo 구현
        ((I1)w).Foo();              // Widget I1.Foo 구현
        ((I2)w).Foo();              // Widget I2.Foo 구현
    }
}



