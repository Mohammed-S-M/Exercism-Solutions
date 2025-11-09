public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string romanNumber = "";
        
        while (value != 0) 
        {
            if (value / 1000 > 0)
            {
                romanNumber += "M";
                value -= 1000;
            }
            else if (value / 100 > 0) 
            {
                if (value / 900 > 0) 
                {
                    romanNumber += "CM";
                    value -= 900;
                }
                else if (value / 500 > 0) 
                {
                    romanNumber += "D";
                    value -= 500;
                }
                else if (value / 400 > 0) 
                {
                    romanNumber += "CD";
                    value -= 400;
                }
                else 
                {
                    romanNumber += "C";
                    value -= 100;
                }
            }
            else if (value / 10 > 0) 
            {
                if (value / 90 > 0) 
                {
                    romanNumber += "XC";
                    value -= 90;
                }
                else if (value / 50 > 0) 
                {
                    romanNumber += "L";
                    value -= 50;
                }
                else if (value / 40 > 0) 
                {
                    romanNumber += "XL";
                    value -= 40;
                }
                else 
                {
                    romanNumber += "X";
                    value -= 10;
                }
            }
            else if (value / 1 > 0)
            {
                if (value / 9 > 0) 
                {
                    romanNumber += "IX";
                    value -= 9;
                }
                else if (value / 5 > 0) 
                {
                    romanNumber += "V";
                    value -= 5;
                }
                else if (value / 4 > 0) 
                {
                    romanNumber += "IV";
                    value -= 4;
                }
                else 
                {
                    romanNumber += "I";
                    value -= 1;
                }
            }
        }

        return romanNumber;
    }
}

// 3999 convert it to Roman = 