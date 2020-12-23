using System;
using Lb8;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            Set<int> intSet = new Set<int>(intArray);
            intSet.LookUp();
            intSet.Delete(2);
            intSet.LookUp();
            intSet.Add(10);           
            intSet.LookUp();
            Console.WriteLine();
            float[] floatArray = new float[] { 1.2f, 2.4f, 3.6f, 4.2f, 5.56f };
            Set<float> floatSet = new Set<float>(floatArray);
            floatSet.LookUp();
            floatSet.Delete(1.2f);
            floatSet.LookUp();
            floatSet.Add(10);
            floatSet.LookUp();
            Console.WriteLine();
            News newsObj = new News("Russia Today", 70, "Новости о России сегодня", "Россия");
            FeatureFilm ffObj = new FeatureFilm("Interstellar", 250, "Фильм про космос и черные дыры", 16, "26.10.2014", "Matthew MacConaughey");
            Cartoon cartObj = new Cartoon("The Incredibles", 116, "Фильм про суперсемейку", 5, "5.11.2004", "Mr. Incredible");
            Cartoon cartObj2 = new Cartoon("Shrek 2", 105, "Фильм про огра", 5, "19.5.2004", "Shrek");
            TVProgram[] tvArr = new TVProgram[] { newsObj, ffObj, cartObj, cartObj2 };
            Set<TVProgram> tvSet = new Set<TVProgram>(tvArr);
            tvSet.Sort();
            tvSet.LookUp();
            Console.WriteLine();
            tvSet.Delete(ffObj);
            tvSet.LookUp();
            Console.WriteLine();
            tvSet.Add(newsObj);
            tvSet.LookUp();
            Console.WriteLine();
            tvSet.ToFile(@"C:\Users\werto\Desktop\Lab 8\Lab 8\new.txt");
        }
    }
}
