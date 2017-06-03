using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using static System.Console;

class Program
{
    static void Main()
    {
        int loopSize = (int) ReadNum();
        var sB = new StringBuilder();

        for (int i = 0; i < loopSize; i++)
        {
            string temp = ReadLine();
            foreach (var a in temp)
                if (a == '(' || a == ')')
                    sB.Append(a);
        }

        Write((sB.ToString().Contains(")(")&&sB.Length==2)||
        sB.ToString().Contains("((")||
        sB.ToString().Contains("))")||
        sB[0]==')'||sB[sB.Length-1]=='('||
        sB.Length==1?
        "UNBALANCED":"BALANCED");
    }

    static decimal ReadNum()
    {
        string input = ReadLine();
        decimal output;
        decimal.TryParse(input, out output);
        return output;
    }
}
