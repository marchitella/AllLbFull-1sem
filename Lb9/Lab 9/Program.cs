using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace Lab_9
{
    static class Extensions
    {
        public static string DeletePunctuation(ref string str)
        {
            char[] punct = new char[] { '.', ',', ':', ';', '?', '!' };
            char[] arr = str.ToCharArray();
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (!punct.Contains(arr[i])) result += arr[i];
            }
            Console.WriteLine(result);
            return str=result;
        }

        public static string DeleteSymbol(ref string str)
        {
            char[] arr = str.ToCharArray();
            string result = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                result += arr[i];
            }
            Console.WriteLine(result);
            return str = result;
        }

        public static string AddSymbol(ref string str)
        {
            Console.WriteLine($"Введите символ");
            char newch = Convert.ToChar(Console.Read());
            str += newch;
            Console.WriteLine(str);
            return str;
        }

        public static string ToUpperCase(ref string str)
        {
            Console.WriteLine(str.ToUpper());
            return str = str.ToUpper();
        }

        public static string DeleteSpaces(ref string str)
        {
            char space = ' ';
            char[] arr = str.ToCharArray();
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != space) result += arr[i];
            }
            Console.WriteLine(result);
            return result;
        }
    }
        class Program
    {
        delegate string StringHandler(ref string message);
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Tech tech1 = new Tech();
            Tech tech2 = new Tech();
            SemiTech sTech1 = new SemiTech();
            Boss megaBoss = new Boss();
            megaBoss.Upgrading += tech1.OnUpgrading;
            megaBoss.Upgrading += tech2.OnUpgrading;
            megaBoss.Upgrading += sTech1.OnUpgrading;   
            megaBoss.TurningOn += tech1.OnTurningOn;
            megaBoss.Upgrade(2);
            megaBoss.TurnOn(120);
            megaBoss.GetStatus();
            megaBoss.TurnOn(230);
            megaBoss.GetStatus();   
            Console.WriteLine($"Кол-во реакций объекта tech - {tech1.EventReaction}");
            Console.WriteLine($"Кол-во реакций объекта sTech - {sTech1.EventReaction}");
            StringHandler strh;
            string str1 = "Hello, Mark!";
            strh = Extensions.DeletePunctuation;            
            strh += Extensions.DeleteSymbol;            
            strh += Extensions.AddSymbol;
            strh += Extensions.ToUpperCase;           
            strh += Extensions.DeleteSpaces;                       
            strh(ref str1);
            
            //Лямда выражение
            Operation operation = (x, y) => x + y;
            Console.WriteLine(operation(10, 20));       // 30
            Console.WriteLine(operation(40, 20));       // 60
            Console.Read();

        }
    }
}
