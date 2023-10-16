using Canary.Models;

namespace Canary.Services;

public static class NumberService
{
    static List<Number> Numbers { get; }
    static NumberService()
    {
        Numbers = new List<Number>
        { };

    }

    public static List<Number> GetAll() => Numbers;

    public static Number? Get(string num) => Numbers.FirstOrDefault(n => n.Num == num);

    public static void Add(Number number)
    {
        Numbers.Add(number);
    }

    public static string ConvertStringToNumber(string numberString)
    {
        string result = "";

        string[] lines = numberString.Split("\n");

        char[] line1 = lines[0].ToCharArray();
        char[] line2 = lines[1].ToCharArray();
        char[] line3 = lines[2].ToCharArray();

        for (int i = 0; i < (lines.Length - 2); i += 4)
        {
            line1 = lines[i].ToCharArray();
            line2 = lines[i + 1].ToCharArray();
            line3 = lines[i + 2].ToCharArray();

            int mod = 3;
            string exp = "";

            for (int j = 0; j < line1.Length; j++)
            {
                if ((j % mod) == 0)
                {
                    string strAs = digitToString(exp);
                    result += strAs;
                    exp = "";

                }
                if (line1[j].Equals('_') && (j % mod == 1))
                {
                    exp += "0";
                }
                if (line2[j].Equals('|') && (j % mod == 0))
                {
                    exp += "5";
                }
                if (line2[j].Equals('|') && (j % mod == 2))
                {
                    exp += "1";
                }
                if (line2[j].Equals('_') && (j % mod == 1))
                {
                    exp += "6";
                }
                if (line3[j].Equals('|') && (j % mod == 0))
                {
                    exp += "4";
                }
                if (line3[j].Equals('|') && (j % mod == 2))
                {
                    exp += "2";
                }
                if (line3[j].Equals('_') && (j % mod == 1))
                {
                    exp += "3";
                }

                if ((line1.Length - 1) == j)
                {
                    string strAs = digitToString(exp);
                    result += strAs;
                    exp = "";
                }
            }
            //result += "\n";
        }
        return result;
    }

    public static string digitToString(string asciiDigit)
    {
        if (asciiDigit == null || asciiDigit.Equals(""))
            return "";
        double exp = 0;

        for (int i = 0; i < asciiDigit.Length; i++)
        {
            int intValue = asciiDigit[i] - '0';
            exp += Math.Pow(2, Convert.ToDouble(intValue));
        }

        int expInt = Convert.ToInt32(exp);


        Dictionary<int, int> dict = new Dictionary<int, int>
        {
            { 63, 0 },
            { 6, 1 },
            { 91, 2 },
            { 79, 3 },
            { 102, 4 },
            { 109, 5 },
            { 125, 6 },
            { 7, 7 },
            { 127, 8 },
            { 111, 9 }
        };

        //return dict[expInt].ToString();
        return dict.ContainsKey(expInt) ? dict[expInt].ToString() : "?";
    }

}



