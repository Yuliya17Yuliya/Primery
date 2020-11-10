using System;
using System.IO;
using System.Threading.Channels;
using System.Text;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace Zadachi12
{
    class Program
    {
        static void Main(string[] args)
        {

            // чтение файла (приобразовать с кодировкой)
            // FileStream file = new FileStream("D:\\f1.txt", FileMode.Open, FileAccess.Read);
            // StreamReader reader = new StreamReader(file);

            // string s;
            // string s = File.ReadAllText(@"D:\\f1.txt", Encoding.Default).Replace("\n", " "); // использование метода ReadAllText класса File без использования потоковых классов! с возможностью читать русскую и иную кодировку!

            // int[] s = System.IO.File.ReadAllText("D://f1.txt", Encoding.Default).Split(' ').Select(int.Parse).ToArray(); // чтение из файла в целочсиленный массив, разделитель пробел, преобразователь - Select в классе System.Linq

            // int[] s = File.ReadAllText("D://f1.txt").Split(' ').Select(int.Parse).ToArray(); сокращенная запись

            double[] s = File.ReadAllText("D://f1.txt").Split(',').Select(double.Parse).ToArray(); // 
            // посмотреть методы Select и Split для дробных или действительных чисел


            // s = reader.ReadToEnd();

            // Console.WriteLine($"{s}");

            /*
            // подход к строке как к тексту
            int k = 0;

            for (int i = 0; i < s.Length - 2; i++)
            
                if (s.Substring(i, 2) == "ab") k++;

            for (int i = 0; i < s.Length - 8; i++)

                if (s.Substring(i, 8) == "abcdefgh") Console.WriteLine("+");
                else Console.WriteLine("-");
            */

            // подход как к массиву возможен только при проверке 1 символа подсчитать количество предложений

            //int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //if (s[i] == '.' || s[i] == '?' || s[i] == '!') k++;
                Console.Write(s[i]);
            }

            //
            // string s = System.IO.File.ReadAllText(@"fileName.txt", Encoding.Default).Replace("\n", " ");

            // чтение из файла 
            //int[] array = File.ReadAllText("D://1.txt", Encoding.Default).Split(' ').Select(x => int.Parse(x)).ToArray();


            // чтение из файла 
            //int[] array = File.ReadAllText("D://1.txt", Encoding.Default).Split(' ').Select(x => int.Parse(x)).ToArray();


            // Задание: ввести в поисковик "открытые проекты на Githab для начинающих ". репезиториев посмотреть репезитории, что это такое гиты!!!!!!





            // Console.WriteLine(k);

            using (FileStream fstream = File.OpenRead($"D://1.txt"))
            {
                string[] arr = File.ReadAllText("D://1.txt", Encoding.Default).Split(' ').ToArray();
                double[] array = new double[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    array[i] = double.Parse(arr[i]);
                }
            }

string[] arr = File.ReadAllText("D://1.txt", Encoding.Default).Split(' ').ToArray();
            double[] array = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = double.Parse(arr[i]);
            }














            Console.ReadKey();


        }
    }
}
