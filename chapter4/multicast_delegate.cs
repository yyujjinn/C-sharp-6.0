using System;

public delegate void ProgressReporter(int percentComplete);

public class Util
{
    public static void HardWork(ProgressReporter p)
    {
        for (int i = 0; i < 10; i++)
        {
            p(i * 10);                          // 대리자 호출
            System.Threading.Thread.Sleep(100); // 어려운 작업을 흉내 낸다.
        }
    }
}

class Test
{
    static void Main()
    {
        ProgressReporter p = WriteProgressToConsole;
        p += WriteProgressToFile;
        Util.HardWork(p);
    }

    static void WriteProgressToConsole(int percentComplete)
        => Console.WriteLine(percentComplete);

    static void WriteProgressToFile(int percentComplete)
        => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
}