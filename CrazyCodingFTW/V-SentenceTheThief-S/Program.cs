using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using static System.Console;

class Program
{
    static void Main()
    {
        string valueType = ReadLine();
        int ids = (int) ReadNum();
        long[] id = new long[ids];

        for (int i = 0; i < ids; i++)
            id[i] = long.Parse(ReadLine());
        Array.Sort(id);

        long thiefID = 0l;
        switch (valueType)
        {
            case "sbyte":
                thiefID = sbyte.Parse(LookForID(id,sbyte.MinValue, sbyte.MaxValue));
                break;
            case "int":
                thiefID = int.Parse(LookForID(id,int.MinValue, int.MaxValue));
                break;
            case "long":
                thiefID = long.Parse(LookForID(id,long.MinValue, long.MaxValue));
                break;
        }

        long sentenceTime = (long)Math.Ceiling(thiefID/ (double) (thiefID<0 ? sbyte.MinValue : sbyte.MaxValue));

        WriteLine($"Prisoner with id {thiefID} is sentenced to {sentenceTime} {(sentenceTime>1?"years":"year")}");
    }

    static string LookForID<TVariable>(long[] ID,TVariable minValue, TVariable maxValue)
    {
        for (int i = 0; i < ID.Length-1; i++)
        {
            if (ID[i] <= long.Parse(maxValue.ToString()) && ID[i + 1] > long.Parse(maxValue.ToString())&&ID[i]>=long.Parse(minValue.ToString()))
                return ID[i].ToString();
            if (ID[i + 1] <= long.Parse(maxValue.ToString()) && i == ID.Length - 2&&ID[i+1]>=long.Parse(minValue.ToString()))
                return ID[i + 1].ToString();
        }
        return null;
    }

    static decimal ReadNum()
    {
        string input = ReadLine();
        decimal output;
        decimal.TryParse(input, out output);
        return output;
    }
}
