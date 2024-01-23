namespace Bmi  // package controller  dao
//package bmicaculator; //Java
//import dao;
//using dao;
//using Bmi;

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double bmi = GetBMI(70, 1.7);

            Console.WriteLine("1. Your BMI is " + bmi);  //print the message by
                                                         //concatenating strings - ghép chuỗi - JAVA
            Console.WriteLine("2. Your BMI is {0}", bmi); //place holder
                                                          //each variable is mapped with a
                                                          //space in the target string
                                                          //the order of the used vars begins with 0
            Console.WriteLine("3. Your BMI is {0} | {1}", bmi, 2024);

            Console.WriteLine($"4. Your BMI is {bmi}"); //interpolation

            Console.WriteLine($"5. Your BMI is {BmiCalculator.GetBMI(70, 1.7)}");

            bmi = BmiCalculator.GetBMI(70, 1.7);

            Console.WriteLine(BmiCalculator.EvaluateBmiStatus(bmi));

        }

        static double GetBMI(double weight, double height) => weight / (height * height);
        //ko đc nhầm lãn mũi tên => với biểu thức Lamba học sau
        //do cả 2 style đều xài chung =>
        //hàm chỉ có 1 lệnh duy nhất, đc phép rút gọn code, rút gọn luôn
        //cả lệnh return, cú pháp này gọi là BODY-EXPRESSION




        //static chỉ chơi với static
        //static double GetBMI(double weight, double height)
        //{
        //    return weight / (height * height);
        //}   //select a block of code and press Ctrl - K - C 
        //to comment a block of code
        //Ctrl K U để mở lại
    }


}
