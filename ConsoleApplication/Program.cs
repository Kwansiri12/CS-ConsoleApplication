using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string name = "";
            int height = 0;
            int weight = 0;
            string gender = "";

            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            // --------------------------
            // รับชื่อ (ภาษาอังกฤษเท่านั้น)
            // --------------------------
            while (true)
            {
                Console.Write("Please input full name (Eng): ");
                name = Console.ReadLine().Trim();

                // ตรวจสอบ: ต้องไม่ว่าง และต้องเป็น a-z หรือ A-Z
                if (!string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[A-Za-z ]+$"))
                    break;
                else
                    Console.WriteLine("❌ Name must contain only English letters (A-Z) and cannot be empty. Please try again.\n");
            }

            // --------------------------
            // รับเพศ (m หรือ f)
            // --------------------------
            while (true)
            {
                Console.Write("Please enter your gender (m or f): ");
                gender = Console.ReadLine().Trim().ToLower();

                if (gender == "m" || gender == "f")
                    break;
                else
                    Console.WriteLine("❌ Gender must be 'm' or 'f'. Please try again.\n");
            }

            // --------------------------
            // รับส่วนสูง (ต้องเป็นตัวเลข และ > 0)
            // --------------------------
            while (true)
            {
                Console.Write("Please enter your height (cm): ");
                string input = Console.ReadLine().Trim();

                if (int.TryParse(input, out height) && height > 0)
                    break;
                else
                    Console.WriteLine(" Height must be a positive number. Please try again.\n");
            }

            // --------------------------
            // คำนวณน้ำหนักมาตรฐาน
            // --------------------------
            weight = height - 100;

            Console.WriteLine();
            Console.WriteLine("Hello, Welcome " + name);
            Console.WriteLine("Your ideal weight is: " + weight + " kg");

            Console.WriteLine();
            Console.WriteLine("Press Q to end program");
            Console.ReadKey();
        }
    }
}
