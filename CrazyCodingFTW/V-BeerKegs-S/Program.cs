using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using static System.Console;

class Keg
{
    private decimal kegVolume;

    public decimal KegVolume => kegVolume;
    public string KegType { set; get; }

    internal Keg(string kegType, decimal radius, int height)
    {
        KegType = kegType;
        kegVolume = (decimal)Math.PI * radius * radius * height;
    }

    public static bool operator <(Keg a, Keg b) => a.KegVolume < b.KegVolume;
    public static bool operator >(Keg a, Keg b) => a.KegVolume > b.KegVolume;
}

class Program
{
    static void Main()
    {
       Keg[] keg = new Keg[(int)ReadNum()];
        for (int i = 0; i < keg.Length; i++)
            keg[i] = new Keg(ReadLine(),ReadNum(),(int)ReadNum());

        Keg biggestKeg = new Keg(null, 0, 0);
        for (int i = 0; i < keg.Length; i++)
            biggestKeg = keg[i] > biggestKeg ? keg[i] : biggestKeg;
            
         WriteLine(biggestKeg.KegType);
    }

    static decimal ReadNum()
    {
        string input = ReadLine();
        decimal output;
        decimal.TryParse(input, out output);
        return output;
    }
}
