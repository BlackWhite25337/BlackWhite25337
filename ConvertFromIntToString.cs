using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblastnoi_Sud.MyClass
{
	class ConvertFromIntToString
	{
		static public string FromIntToString(int i)
		{
			try
			{
                string result = "";
                string[] ones = { "", "один", "два", "три", "четыре", 
                    "пять", "шесть", "семь", "восемь", "девять", "десять",
                    "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", 
                    "пятнадцать", "шестнадцать", "семнадцать", 
                    "восемнадцать", "девятнадцать" };
                string[] tens = { "", "", "двадцать", "тридцать", 
                    "сорок", "пятьдесят", "шестьдесят", 
                    "семьдесят", "восемьдесят", "девяносто" };
                string[] hundreds = { "", "сто", "двести", 
                    "триста", "четыреста", "пятьсот", 
                    "шестьсот", "семьсот", "восемьсот", 
                    "девятьсот" };
                string[] thousands = { "", "одна тысяча", 
                    "две тысячи", "три тысячи", 
                    "четыре тысячи", "пять тысяч", 
                    "шесть тысяч", "семь тысяч", 
                    "восемь тысяч", 
                    "девять тысяч" };

                int onesDigit = i % 10;
                int tensDigit = (i / 10) % 10;
                int hundredsDigit = (i / 100) % 10;
                int thousandsDigit = (i / 1000) % 10;

                if (thousandsDigit > 0)
                {
                    result += thousands[thousandsDigit] + " ";
                }

                if (hundredsDigit > 0)
                {
                    result += hundreds[hundredsDigit] + " ";
                }

                if (tensDigit == 1)
                {
                    result += ones[i % 100] + " ";
                }
                else
                {
                    if (tensDigit > 0)
                    {
                        result += tens[tensDigit] + " ";
                    }
                    if (onesDigit > 0)
                    {
                        result += ones[onesDigit] + " ";
                    }
                }
                return result;

            }
			catch
			{
                return null;
			}
		}

        static public string FromIntToStringU100(int i)
		{
            try
			{
                string result = "";
                string[] ones = { "", "один", "два", "три", 
                    "четыре", "пять", "шесть",
                    "семь", "восемь", "девять",
                    "десять", "одиннадцать", 
                    "двенадцать", "тринадцать", 
                    "четырнадцать", "пятнадцать", 
                    "шестнадцать", "семнадцать", 
                    "восемнадцать", "девятнадцать" };
                string[] tens = { "", "", "двадцать", 
                    "тридцать", "сорок", "пятьдесят", 
                    "шестьдесят", "семьдесят", 
                    "восемьдесят", "девяносто" };
                int onesDigit = i % 10;
                int tensDigit = i / 10;

                if (tensDigit == 0)
                {
                    result = ones[onesDigit];
                }
                else if (tensDigit == 1)
                {
                    result = ones[i];
                }
                else
                {
                    result = tens[tensDigit] + " " + ones[onesDigit];
                }
                return result;
            }
            catch
			{
                return null;
			}
		}
	}
}
