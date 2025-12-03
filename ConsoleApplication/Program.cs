namespace ConsoleApplication
{
    using System;

    namespace BMI_Calculator
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //รับชื่อ
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                

                // รับค่าน้ำหนัก
                Console.Write("Enter your weight (kg): ");
                double weight = double.Parse(Console.ReadLine());

                // รับค่าส่วนสูง
                Console.Write("Enter your height (cm): ");
                double heightCm = double.Parse(Console.ReadLine());

                // แปลงเป็นเมตร
                double heightM = heightCm / 100;

                // คำนวณ BMI
                double bmi = weight / (heightM * heightM);

                // แสดงค่า BMI
                Console.WriteLine($"\nYour BMI is: {bmi:F2}");

                // แปลผล BMI
                string result = ""; // ผลลัพธ์การแปลผล BMI

                if (bmi < 18.5)
                {
                    result = "Underweight"; //ผอมเกินไป
                }
                else if (bmi >= 18.5 && bmi <= 22.9)
                {
                    result = "Normal weight"; //น้ำหนักปกติ
                }
                else if (bmi >= 23 && bmi <= 24.9)
                {
                    result = "Overweight"; //น้ำหนักเกิน
                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    result = "Obese (Level 1)"; //อ้วนระดับ 1
                }
                else
                {
                    result = "Obese (Level 2)";//อ้วนระดับ 2
                }

                Console.WriteLine("Result: " + result); // แสดงผลลัพธ์
            }
        }
    }

}
