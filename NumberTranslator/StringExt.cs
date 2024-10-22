using NumberTranslator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTranslator;

internal static class StringExt
{
    public static string ConvertMyNum(this string num, byte from, byte to)
    {
        bool isNegative = false;
        if (num.StartsWith('-'))
        {
            num = num.Substring(1);
            isNegative = true;
        }
        int convertNum;
        try
        {
            convertNum = num.ConvertToDecimal(from);
        } catch (InvalidSymbolException e)
        {
            throw new InvalidSymbolException(e.Message);
        } catch (IncorrectNumberSystem e)
        {
            throw new IncorrectNumberSystem(e.Message);
        }

        return isNegative ? $"-{DumbConvert(convertNum, to)}" : DumbConvert(convertNum, to);
    }
    public static string ConvertToBinary(this string str, byte from)
    {
        bool isNegative = false;
        if (str.StartsWith('-')) {
            str = str.Substring(1);
            isNegative = true;
        }
        int decimalNum;
        try
        {
            decimalNum = str.ConvertToDecimal(from);
        }
        catch (InvalidSymbolException e)
        {
            throw new InvalidSymbolException(e.Message);
        }
        catch (IncorrectNumberSystem e)
        {
            throw new IncorrectNumberSystem(e.Message);
        }
        if (decimalNum == 0)
        {
            return "0";
        }
        string res = DumbConvert(decimalNum, 2);

        int numOfDigits = (res.Length + 3) / 4;

        char[] chars = Invert((new string('0', numOfDigits * 4 - res.Length) + res).ToCharArray());
        for (int i = chars.Length - 1, up = 1; i >= 0; --i)
        {
            if (chars[i] == 48 && up == 1)
            {
                chars[i] = '1';
                up = 0;
            }
        }
        return isNegative ? $"-{res} ПК: {new string(chars)}" : $"{res}";
    }
    private static char[] Invert(char[] chars) => chars.Select(c => c == '0' ? '1' : '0').ToArray();

    public static int ConvertToDecimal(this string num, byte from) 
    {
        int result = 0;
        for (int i = 0; i < num.Length; ++i)
        {
            int convertNum;
            if (num[i] >= '0' && num[i] <= '9')
            {
                convertNum = num[i] - '0';
            }
            else if (num[i] >= 'A' && num[i] <= 'F')
            {
                convertNum = num[i] - 'A' + 10;
            }
            else
            {
                throw new InvalidSymbolException($"Недопустимый символ '{num[i]}' в числе.");
            }

            if (convertNum >= from)
            {
                throw new IncorrectNumberSystem($"Цифра '{num[i]}' недопустима для системы счисления {from}.");
            }

            result += convertNum * (int)Math.Pow(from, num.Length - 1 - i);
        }
        return result;
    }
    public static string DumbConvert(int num, byte to)
    {
        if (to == 10)
            return num.ToString();

        const string digits = "0123456789ABCDEF";
        string result = "";

        bool isNegative = num < 0;
        num = Math.Abs(num);

        do
        {
            result = digits[num % to] + result;
            num /= to;
        }
        while (num > 0);

        return isNegative ? "-" + result : result;
    }
}
