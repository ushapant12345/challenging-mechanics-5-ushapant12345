using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenging_mechanics_5_ushapant12345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <returns>True if number1 and number2 are equal in value</returns>
        private bool AreEqual(int num1, int num2)
        {
            return num1 == num2;
        }


        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <returns>True if number1 and number2 are equal in value</returns>
        private bool AreEqual(double num1, double num2)
        {
            return num1 == num2;
        }


        /// <summary>
        /// Check if two strings are same
        /// </summary>
        /// <param name="String1">first string</param>
        /// <param name="String2">second string</param>
        /// <returns>True if String1 and String2 are same </returns>
        private bool AreEqual(String String1, String String2)
        {
            return String1 == String2;
        }


        /// <summary>
        /// Check if two characters are same
        /// </summary>
        /// <param name="char1">first character</param>
        /// <param name="char2">second character</param>
        /// <returns>True if char1 and char2 are same</returns>
        private bool AreEqual(Char char1, Char char2)
        {
            return char1 == char2;
        }

        /// <summary>
        /// Check if two booleans are equal
        /// </summary>
        /// <param name="bool1">first value</param>
        /// <param name="bool2">second value</param>
        /// <returns>True if both values are true</returns>
        private bool AreEqual(bool bool1, bool bool2)
        {
            return bool1 == bool2;
        }





        /// <summary>
        /// Check if one boolean value is true
        /// </summary>
        /// <param name="bool1">first value</param>
        /// <param name="bool2">second value</param>
        /// <returns>True if only one value is true</returns>
        private bool onetrue(bool bool3, bool bool4)
        {
            return bool3 ^ bool4;
        }


        /// <summary>
        /// Check if both boolean values are false
        /// </summary>
        /// <param name="bool3">first value</param>
        /// <param name="bool4">second value</param>
        /// <returns>True if both values are false</returns>
        private bool bothfalse(bool bool3, bool bool4)
        {
            return bool3 != bool4;
        }


        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <returns>True if number1 is greater in value than number2</returns>
        private bool FirstIsBigger(int num1, int num2)
        {
            return num1 > num2;
        }




        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">integer value</param>
        /// <param name="num2">double value</param>
        /// <returns>True if integer is greater than double</returns>
        private bool IntegerIsBigger(int num1, double num2)
        {
            return num1 > num2;
        }



        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">integer value</param>
        /// <param name="num2">double value</param>
        /// <returns>True if integer is smaller than double</returns>
        private bool DoubleIsBigger(int num1, double num2)
        {
            return num1 < num2;
        }


        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">integer value</param>
        /// <param name="num2">double value</param>
        /// <returns>True if integer is greater than or equal to double</returns>
        private bool IntegerIsequalandBigger(int num1, double num2)
        {
            return num1 >= num2;
        }


        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num1">first value</param>
        /// <param name="num2">second value</param>
        /// <returns>Returns first value when first value is greater than the second otherwise returns second value</returns>
        private double Double(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }

            else
            {
                return num2;
            }
        }



        /// <summary>
        /// Check if two numbers are equal
        /// </summary>
        /// <param name="num3">first value</param>
        /// <param name="num4">second value</param>
        /// <returns>Returns first value when first value is smaller than the second otherwise returns second value</returns>
        private double bothdouble(double num3, double num4)
        {
            if (num3 < num4)
            {
                return num3;
            }

            else
            {
                return num4;
            }
        }




        /// <summary>
        /// Calculate the sum of two integers
        /// </summary>
        /// <param name="num1"> first integer value</param>
        /// <param name="num2">second value</param>
        /// <returns>returns the sum of two integers</returns>
        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        /// <summary>
        /// Calculate the sum of three integers
        /// </summary>
        /// <param name="num1"> first integer value</param>
        /// <param name="num2">second int value</param>
        /// <param name="num3">third int value</param>
        /// <returns>returns the sum of three integers</returns>
        private int Sum(int num1, int num2 ,int num3)
        {
            return num1 + num2 + num3;
        }


        /// <summary>
        /// Calculate the sum of four integers
        /// </summary>
        /// <param name="num1"> first integer value</param>
        /// <param name="num2">second int value</param>
        /// <param name="num3">third int value</param>
        /// <param name="num4">fourth int value</param>
        /// <returns>returns the sum of four integers</returns>
        private int Sum(int num1, int num2, int num3,int num4)
        {
            return num1 + num2 + num3 +num4;
        }



        /// <summary>
        /// Calculate the sum of five integers
        /// </summary>
        /// <param name="num1"> first integer value</param>
        /// <param name="num2">second int value</param>
        /// <param name="num3">third int value</param>
        /// <param name="num4">fourth int value</param>
        /// <param name="num5">fifth int value</param>
        /// <returns>returns the sum of five integers</returns>
        private int Sum(int num1, int num2, int num3, int num4 , int num5)
        {
            return num1 + num2 + num3 + num4 + num5;
        }


        /// <summary>
        /// Calculate the sum of two doubles
        /// </summary>
        /// <param name="num1"> first doubler value</param>
        /// <param name="num2">second double value</param>
        /// <returns>returns the sum of two doubles</returns>
        private double Sum(double num1, double num2)
        {
            return num1 + num2;
        }



        /// <summary>
        /// Calculate the sum of integer and double
        /// </summary>
        /// <param name="num1">double value</param>
        /// <param name="num2">integer value</param>
        /// <returns>returns the sum of integer and double</returns>
        private double Sum(double num1, int num2)
        {
            return num1 + num2;
        }



        /// <summary>
        /// Calculate the sum of integer and double
        /// </summary>
        /// <param name="num1"> first double value</param>
        /// <param name="num2">second double value</param>
        /// <param name="num3">integer value</param>
        /// <returns>returns the sum of doubles and integer</returns>
        private double Sum(double num1, double num2, int num3)
        {
            return num1 + num2 + num3;
        }


        /// <summary>
        /// Calculate the sum of integer and double
        /// </summary>
        /// <param name="num1"> first double value</param>
        /// <param name="num2">integer value</param>
        /// <param name="num3">second double value</param>
        /// <returns>returns the sum of doubles and integer</returns>
        private double Sum(double num1, int num2, double num3)
        {
            return num1 + num2 + num3;
        }



        /// <summary>
        /// Calculate the sum of integer and double
        /// </summary>
        /// <param name="num1"> integer value</param>
        /// <param name="num2">first double value</param>
        /// <param name="num3">second double value</param>
        /// <returns>returns the sum of doubles and integer</returns>
        private double Sum(int num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }


        /// <summary>
        /// Combine the strings
        /// </summary>
        /// <param name="stringone"> first String</param>
        /// <param name="stringtwo">second String</param>
        /// <returns>returns the combined strings</returns>
        private String Sum(String stringone , String stringtwo)
        {
            return stringone + stringtwo;

        }


        /// <summary>
        /// Combine the strings
        /// </summary>
        /// <param name="stringone"> first String</param>
        /// <param name="stringtwo">second String</param>
        /// <param name="stringthree">third String</param>
        /// <returns>returns the combined strings</returns>
        private String Sum(String stringone, String stringtwo , String stringthree)
        {
            return stringone + stringtwo  + stringthree;

        }


        /// <summary>
        /// Combine the strings
        /// </summary>
        /// <param name="stringone"> first String</param>
        /// <param name="stringtwo">second String</param>
        /// <param name="stringthree">third String</param>
        /// <param name="stringfour">third String</param>
        /// <returns>returns the combined strings</returns>
        private String Sum(String stringone, String stringtwo, String stringthree, String stringfour)
        {
            return stringone + stringtwo + stringthree + stringfour;


        }





        /// <summary>
        /// Combine the characters
        /// </summary>
        /// <param name="charone"> first Character</param>
        /// <param name="chartwo">second Character</param>
        /// <returns>returns the combined characters</returns>
        private String Sum(Char charone, Char chartwo)
        {
            String add =  " "+ charone + chartwo;
            return add;

        }



        /// <summary>
        /// Combine the characters
        /// </summary>
        /// <param name="charone"> first Character</param>
        /// <param name="chartwo">second Character</param>
        /// <param name="charthree">third Character</param>
        /// <returns>returns the combined characters</returns>
        private String Sum(Char charone, Char chartwo , Char charthree)
        {
            String add = " " + charone + chartwo +charthree;
            return add;

        }




        /// <summary>
        /// Combine the characters
        /// </summary>
        /// <param name="charone"> first Character</param>
        /// <param name="chartwo">second Character</param>
        /// <param name="charthree">third Character</param>
        /// <param name="charfour">fourth Character</param>
        /// <returns>returns the combined characters</returns>
        private String Sum(Char charone, Char chartwo, Char charthree ,Char charfour)
        {
            String add = " " + charone + chartwo + charthree + charfour;
            return add;

        }


        /// <summary>
        /// Append the string with character
        /// </summary>
        /// <param name="charone"> first Character</param>
        /// <param name="stringfive">String</param>
        /// <returns>returns the appended form</returns>
        private String Sum(String stringfive,Char charone)
        {

            return stringfive + charone;

        }



        /// <summary>
        /// Append the character with string
        /// </summary>
        /// <param name="charone"> first Character</param>
        /// <param name="stringfive">String</param>
        /// <returns>returns the appended form</returns>
        private String Sum( Char charone ,String stringfive)
        {

            return charone + stringfive;

        }



        /// <summary>
        /// Append the characters and string
        /// </summary>
        /// <param name="charone"> first Character</param>
        /// <param name="stringfive">String</param>
        /// <param name="chartwo">second Character</param>
        /// <returns>returns the appended form</returns>
        private String Sum( Char charone , String stringfive, Char chartwo)
        {

            return charone + stringfive + chartwo;

        }

        /// <summary>
        /// Append the string with integer
        /// </summary>
        /// <param name="value1"> integer</param>
        /// <param name="stringfive">String</param>
        /// <returns>returns the appended form</returns>
        private String Sum(String stringfive, int value1)
        {

            return stringfive + value1;

        }


        /// <summary>
        /// Append the string with double
        /// </summary>
        /// <param name="value1"> double</param>
        /// <param name="stringfive">String</param>
        /// <returns>returns the appended form</returns>
        private String Sum(String stringfive, double value1)
        {

            return stringfive + value1;

        }


        /// <summary>
        /// Append the string with integer
        /// </summary>
        /// <param name="value1"> integer</param>
        /// <param name="stringfive">String</param>
        /// <returns>returns the appended form</returns>
        private String Sum( int value1, String stringfive)
        {

            return value1 + stringfive;

        }

        /// <summary>
        /// Append the string with double
        /// </summary>
        /// <param name="value1"> double</param>
        /// <param name="stringfive">String</param>
        /// <returns>returns the appended form</returns>
        private String Sum( double value1, String stringfive)
        {

            return value1 + stringfive;

        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            int answer1 = Sum(3, 5);
            int answer2 = Sum(11, 3);
            int answer3 = Sum(1, 2, 3);
            int answer4 = Sum(13, 4, 97, 11);
            double answer5 = Sum(1.3, 83.7);
            double answer6 = Sum(10.8, 7);
            double answer7 = Sum(56.6, 4);
            double answer8 = Sum(56.0, 23.7, 4);
            String answer9 = Sum("Hello" ,"world");
            String answer10 = Sum("Good-bye", "cruel", "world");
            String answer11 = Sum('a', 'b', 'c');
            String answer12 = Sum('o', "clock");
            String answer13 = Sum('a', "lphabe", 't');
            String answer14 = Sum("gr", 8);
            String answer15 = Sum("web", 2.0);
            String answer16 = Sum(12, "dozen eggs");



        }



        /// <summary>
        /// Calculate the sum of two integers
        /// </summary>
        /// <param name="num1"> first integer value</param>
        /// <param name="num2">second value</param>
        /// <returns>returns the sum of two integers</returns>
        private int AddThese(int num1, int num2)
        {
            return Sum(num1,num2);
        }



        
        /// <summary>
        /// Calculate the sum of two doubles
        /// </summary>
        /// <param name="num1"> first double value</param>
        /// <param name="num2">doubles value</param>
        /// <returns>returns the sum of two doubles</returns>
        private double AddThese(double num1, double num2)
        {
            return Sum(num1,num2);
        }


        /// <summary>
        /// Sum four numbers together
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <param name="num3">third number</param>
        /// <param name="num4">fourth number</param>
        /// <returns>the sum of all four numbers</returns>
        private double AddThese(double num1, double num2, double num3, double num4)
        {
            return Sum(num1, num2) + Sum(num3, num4);
        }

        /// <summary>
        /// Sum three numbers together
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <param name="num3">third number</param>
        /// <returns>the sum of all three numbers</returns>
        private double AddThese(double num1, double num2, double num3)
        {
            return Sum(Sum(num1,num2),num3);
        }

        /// <summary>
        /// Sum three numbers together
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <param name="num3">third number</param>
        /// <returns>the sum of all three numbers</returns>
        private int AddThese(int num1, int num2, int num3)
        {
            return Sum(Sum(num1,num2),num3);
        }

        /// <summary>
        /// Sum four numbers together
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <param name="num3">third number</param>
        /// <param name="num4">fourth number</param>
        /// <returns>the sum of all four numbers</returns>
        private int AddThese(int num1, int num2, int num3, int num4)
        {
            return Sum(Sum(num1, num2),Sum(num3, num4));
        }

    }
}


          

