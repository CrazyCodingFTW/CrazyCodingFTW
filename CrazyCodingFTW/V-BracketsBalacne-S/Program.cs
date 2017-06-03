using System;

using System.Globalization;

using System.Reflection.Emit;

using System.Text;

using static System.Console;


public class Program

{

    public static void Main()

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


        if(sB.Length%2!=0)
				{
					WriteLine("UNBALANCED");
					return;
				}
				for(int i=0;i<sB.Length;i++)
				{
					if(i%2==0&&sB[i]==')')
					{
						WriteLine("UNBALANCED");
						return;
					}
					else if(i%2!=0&&sB[i]=='(')
					{
							WriteLine("UNBALANCED");
							return;
					}
				}
				WriteLine("BALANCED");

    }


    static decimal ReadNum()

    {

        string input = ReadLine();

        decimal output;

        decimal.TryParse(input, out output);

        return output;

    }

}

