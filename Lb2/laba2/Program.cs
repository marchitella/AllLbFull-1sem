using System;
using System.Text;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое Задание"); // переменные всех возможных примитивных типов 
            char m1 = 'm';//символьный
            Console.WriteLine("char  " + m1);
            bool m2 = true;//логический
            Console.WriteLine("bool  " + m2);
            byte m3 = 1;
            Console.WriteLine("byte  " + m3);
            sbyte m4 = -1;
            Console.WriteLine("sbyte  " + m4);
            double m5 = 11.1;
            Console.WriteLine("double  " + m5);
            decimal m6 = 111;
            Console.WriteLine("decimal  " + m6);
            float m7 = 3.5f;
            Console.WriteLine("float  " + m7);
            int m8 = 255;//Целочисленный
            Console.WriteLine("int  " + m8);
            uint m9 = 256;//Без знака
            Console.WriteLine("uint  " + m9);
            long m10 = 111;
            Console.WriteLine("long  " + m10);
            ulong m11 = 112;
            Console.WriteLine("ulong  " + m11);
            short m12 = 222;
            Console.WriteLine("short  " + m12);
            ushort m13 = 223;
            Console.WriteLine("ushort  " + m13);
            string m14 = "mark";//Строковый
            Console.WriteLine("string  " + m14);//ссылочные
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //Неявное преобразование типов, задача перекладывается на транслятор языка
            m8 = m3 + 25;
            m8 = m8 - 'm';
            m5 = m5 - m7;
            m10 = m12 + m8;
            m12 = 'm' - 3;
            //Явное преобразование типов, в момент объявления переменной требуется явно указать тип.
            m8 = (int)(3 + 3.5f);
            m1 = (char)(17 + 30);
            m12 = (short)(m13 + m1);
            m6 = (decimal)(m7);
            m10 = (long)(m8);

            double b = 1.6;//Класс Convert, преобразовывает в другой тип.
            int b1 = Convert.ToInt32(b);//char
            char b2 = Convert.ToChar(23);//int
            bool b3 = Convert.ToBoolean(1.3);//double
            //c
            int c = 3;
            Object box = c; //Упаковка, из области стека в кучу
            int c1 = (int)box; //Распаковка, из области кучи в стек
            //d
            var varint = 80; //Без типа данных
            var varbool = false;
            
            //e
            Nullable<int> nint = 4;                                                         //Что написано
            int? nint2 = null;//?-какое то определенное знач или null
            //f
            var varint2 = 3;

            Console.WriteLine("Второе Задание");
            //2a
            //Если строки разные то -1, если наобор то 0.
            //-1, str1 предшествует второй в порядке сортировки, имеет знач. null.
            string str1 = "first";
            string str2 = "secon";
            Console.WriteLine(String.Compare(str1, str2));//Сравнивание
            //2b
            string str3 = "third";
            string s1 = "Hello";
            string s2 = "Mark";
            string s3 = s1 + ' ' + s2;
            Console.WriteLine(s3);
            s3 = String.Concat(s2, "!!!");//Сложение
            Console.WriteLine(s3);

            string subString = " и Vlad";
            s3 = s3.Insert(4, subString);//Вставка
            Console.WriteLine(s3);

            char[] buff = new char[10];
            s2.CopyTo(0, buff, 0, 4);//Копирование

            subString = subString.Substring(3);
            Console.WriteLine(subString);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //Интерполирование строк
            double a = 3;
            double n = 4;
            Console.WriteLine($"Область правильного треугольника с катетами {a} и {n} равна {0.5 * a * n}");
            Console.WriteLine($"Длина гипотенузы правильного треугольника с катетами {a} и {n} равна {CalculateHypotenuse(a, n)}");

            double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);
            //2c
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            string s5 = "";
            string s6 = null;
            string s7 = "mark";
       
            Console.WriteLine("String s5 {0}.", Test(s5));
            Console.WriteLine("String s6 {0}.", Test(s6));
            Console.WriteLine("String s7 {0}.", Test(s7));
            String Test(string s)
            {
                if (String.IsNullOrEmpty(s))
                    return "is null or empty";
                else
                    return String.Format("(\"{0}\") is neither null nor empty", s);

            }
            //Проверяет, является ли String null значением или String.Empty(пустой строкой) . 
            
            bool TestForNullOrEmpty(string s)
            {
                bool result;
                result = s == null || s == string.Empty;
                return result;
            }

            string s8 = null;
            string s9 = "";
            Console.WriteLine(TestForNullOrEmpty(s8));
            Console.WriteLine(TestForNullOrEmpty(s9));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            
            //Создание строки с помощью StringBuilder.           Разобрать!!!
            StringBuilder sub = new StringBuilder();
            sub.Append("good morning");//Добавление
            Console.WriteLine(sub);
            
            StringBuilder sub2 = new StringBuilder();
            sub2.Append(" dad");
            sub.Insert(12, sub2);
            StringBuilder sub3 = new StringBuilder();
            sub3.Append("hello, ");
            sub.Insert(0, sub3);//вставляем
            Console.WriteLine(sub);
            StringBuilder strBuild = new StringBuilder("New string", 50);
            strBuild.Replace(' ', '|');//Замена
            Console.WriteLine(strBuild);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Третье Задание");
            //3a Матрица
            int[,] intArr = new int[,]
            {
            {1, 2, 3, 4, 5 },
            {6, 7, 8, 9, 10 },
            {11, 12, 13, 14, 15 },
            {16, 17, 18, 19, 20 },
            {21, 22, 23, 24, 25 }
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{intArr[i, j],-5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //3b
            string[] strArr = new string[]
            { "Mark", "play", "footbol", "on", "PSP" };
            foreach (string str13 in strArr)
            {
                Console.Write($"{str13} ");
            }
            Console.WriteLine($"\nlength = {strArr.Length}");
            strArr[4] = strArr[4].Remove(0); //Удаляем
            strArr[4] = strArr[4].Insert(0, "computer"); //Заменяем
            foreach (string str14 in strArr)
            {
                Console.Write($"{str14} ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");//3c
           //3c Ступенчатый массив
            float[][] jaggedArr = new float[3][];
            jaggedArr[0] = new float[2];
            jaggedArr[1] = new float[3];
            jaggedArr[2] = new float[4];
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = float.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int j = 0;
                foreach (int tmp in jaggedArr[i])
                {
                    Console.Write(" " + jaggedArr[i][j]);
                    j++;
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");//3c
            //3d  неявно типизированные переменные для хранения массива и строки.
            var nontypearr = jaggedArr;
            var nontypestr = str1;
            Console.WriteLine("Четвертое задание");
            //4a кортеж из 5 элементов с типами int, string, char, string, ulong.
            (int age, string name, char firstL, string surname, ulong weight) mytuple = (18, "Mark", 'M', "Kuleshov", 90);
            Console.WriteLine(mytuple);
            //4b Выведите кортеж на консоль целиком и выборочно.
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");//3c
            Console.WriteLine($"{mytuple.age}, {mytuple.firstL}, {mytuple.surname}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");//3c
            //4c  Распаковка кортежа в переменные.
            var (one, two, three, four, five) = mytuple;
            var tup2 = (3, 9);
            var tup3 = mytuple.Item3;
            var tup4 = mytuple.Item4;
            //4d Сравните два кортежа.
            var cmptuple = mytuple;
            Console.WriteLine(cmptuple == mytuple);
            cmptuple.Item1 = 19;//Упаковка
            Console.WriteLine(cmptuple == mytuple);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Пятое задание");

            (int maxValue, int minValue, int sum, char firstl) LocalFunction(int[] arr, string str)
            {
                int max = arr[0];
                int min = arr[0];
                char firstl = str[0];
                int sum = 0;

                foreach (int el in arr)
                {
                    if (min > el) min = el;
                    if (max < el) max = el;
                    sum += el;
                }

                return (max, min, sum, firstl);
            }
            int[] arr1 = { 1, 6, -5, 3, 7, 20, 99, -24 };
            var result1 = LocalFunction(arr1, "Marchitella");
            Console.WriteLine(result1);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Шестое задание");
            void func1()
            {
                unchecked//Делаем переполнение, пропускает ошибку.
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }
            void func2()
            {
                checked//Делаем переполнение, НЕ пропускает ошибку.
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }
            func1(); func2();



        }
    }
   
}