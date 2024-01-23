using Zodiac;

namespace NewYearStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enSign = ZodiacCalculator.GetZodiacEnglish(1, 1);
            Console.WriteLine($"Your zodiac: {enSign}");

            var viSign = ZodiacCalculator.GetZodiacVietnamese(enSign);
            //var: inferrent, suy luận kiểu
            //nghĩa là ngay lúc khai báo biến chưa cần khai báo datatype. Lát hồi khi gán giá trị, biến tự đc map với data type tương ứng
            Console.WriteLine($"Your zodiac: {viSign}");

            //BÀI TẬP VỀ NHÀ - ASSIGNMENT #2
            //Hoàn tất app này gồm các cv sau
            //in ra menu gồm 1. Tính BMI 2. Tính Cung Hoàng Đạo 3. Quit
            //Chọn gì thì làm nấy
            //Làm đc validator càng tốt: ngày âm, tháng 15, 30/2
            //cân nặng 
            //nhập data luôn là chuỗi: Console.ReadLine() -> string
            //convert thành số
            //Java Integer.ParseInt()
            //int.
            //double.
            //hỏi ChatGPT
            //dùng vòng lặp do-while 100% giống Java

            //NÔP LMS
            //DEADLINE: 12H TRƯA THỨ 2 22/1/2024
            //NỘP TRỄ KO TÍNH ĐIỂM, 0 ĐIỂM


        }
    }
}
