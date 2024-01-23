using Bmi;
using System.Xml;

namespace Math
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sumAll, sumEven, sumOdd = 0;

            sumAll = SumIntegers(out sumEven);

            sumAll = SumOddIntegers(ref sumOdd);
            //vì ref ko hứa hẹn trong hàm sẽ có trả về hay ko
            //lỏng lẻo trong lời hứa
            //CHO NÊN ĐỂ XÀI REF BẮT BUỘC BIẾN BÊN NGOÀI PHẢI CÓ
            //SẴN 1 DEFAULT VALUE NÀO ĐÓ ĐỂ NGỘ NHỠ HÀM KO THÈM  TRẢ
            //THÌ TA CÒN DEFAULT
            //NẾU HÀM CÓ TRẢ THÌ TA CÓ GIÁ TRỊ MỚI ĐÈ DEFAULT

            Console.WriteLine("Sum odd: " + sumOdd);

        }
        //CẢ REF VÀ OUT ĐC XEM LÀ KĨ THUẬT TRUYỀN THAM CHIẾU
        //PASS BY REFERENCE, TỨC LÀ TRONG HÀM CÓ SỬA GÌ, BIẾN NGOÀI
        //KIA HỐT ĐỦ, BỊ THAY ĐỔI, ĐỨNG ĐÂY THAY ĐỔI ĐẰNG KIA

        //SỬA VALUE TRỰC TIẾP CỦA BIẾN ĐC TRUYỀN VÀO QUA THAM SỐ
        //OUT, REF

        //PASS BY VALUE, KIỂU TRUYỀN THỐNG (int a), em chỉ xin value 
        //của biến truyền vào, hàm em tự xử ko ảnh hưởng ai khác bên 
        //ngoài hàm







        //svm tab, giống Java là psvm tab để tự generate hàm Main()
        //static void Main(string[] args)
        //{
        //    //CheckReadOnlyParam(10);
        //    //PrintIntegerList();

        //    //Console.WriteLine("Sum all: " + SumIntegers());

        //    //xài như bình thường hàm trả về nhiều value

        //    int sumA, sumE;

        //    sumA = SumIntegers(out sumE);
        //    Console.WriteLine("Sum all: " + sumA);
        //    Console.WriteLine("Sum even: " + sumE);
        //    //1 2 3 4 5 6 7 8 9 10
        //    //11 x 5 = 55
        //    //2 4 6 8 10 = 30

        //    //cách xài thứ 2 với biến out trong tham số hàm
        //    sumA = SumIntegers(out int sumAllEvenNumbers);
        //    //khai báo biến hứng value qua ngả out ngay trên quá trình
        //    //gọi hàm
        //    Console.WriteLine($"Sum even numbers {sumAllEvenNumbers}");

        //}


        //1 3 5 7 9 = 25
        static int SumOddIntegers(ref int sumOdd)
        {
            int sumAll = 0, sumO = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;     //cứ có số là dồn vào sumAll
                if (i % 2 != 0)  //nếu lẻ dồn vào biến sumE
                    sumO += i;
            }
           
            sumOdd = sumO; //HÀM REF CÓ THỂ KO CẦN OUT RA
                             //LỎNG LẺO HƠN HÀM OUT
                             //CÁCH XÀI 2 HÀM CX KHÁC

            return sumAll;
        }


        //overload, overloading - quá tải hàm
        //là hiện tượng có thể xảy ra trên bất kì class nào
        //khi có nhiều hàm trùng tên nhau, nhưng khác phần tham số
        //đầu vào - khác theo data type, ko care tên biến

        //static int SumIntegers(double sumEven) //okie, thay = int là toang
        //{
        //    return 0;
        //}
        static int SumIntegers(out int sumEven)
        {
            int sumAll = 0, sumE = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;     //cứ có số là dồn vào sumAll
                if (i % 2 == 0)  //nếu chẵn dồn vào biến sumE
                    sumE += i;
            }
            //xong for xong 2 tổng
            //return sumE;  //lệnh sau sẽ ko chạy, return là kết thúc hàm ngay
            sumEven = sumE; //đẩy value trong hàm ra ngoài qua ngả param
                            //dùng từ khoá out
                            //out: em HỨA sẽ trả về 1 giá trị, BẮT
                            //BUỘC PHẢI GÁN sumEven = 1 cái gì đó!!!
                            //nồi cháo, ấm nước đầy trên bếp bị trào!!! 
            return sumAll;
        }  //XAI OUT BẮT BUỘC PHẢI CÓ GÁN VALUE CHO OUT Ở TRONG HÀM!!!
           //HOẶC BÁO LỖI

        //hàm trả về giá trị
        //tính tổng các số tự nhiên từ 1..100 -> 5050
        //HÀM THIẾT KẾ TỐT LÀ HÀM TRẢ VỀ GIÁ TRỊ CHO AI ĐÓ DÙNG
        //HÀM KO NÊN CÓ LỆNH NHẬP DỮ LIỆU TỪ BÀN PHÍM, HÀM KO NÊN CÓ
        //LỆNH IN RA MÀN HÌNH
        //TA NHẬN VÀO, TRẢ RA -> THIẾT KẾ TỐT MANG Ý NGHĨA THƯ VIỆN
        //REUSE
        static int SumIntegers()
        {
            int sumAll = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumAll += i;
            }

            return sumAll;
        }


        //in ra các số tự nhiên từ 1..100
        static void PrintIntegerList()
        {
            Console.WriteLine("The list of integers from 1..100");
            Console.WriteLine(@"1 2 3
4 5 6 
    7 8 9 
        10 11 12 
            13 14 15 
                  16...");

            Console.WriteLine(@"

"); //xuống hàng 2 dòng kiểu raw verbatim thay vì \n\n

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
        
        
        
        }



        //Mantra: Static chỉ chơi với Static
        static void CheckReadOnlyParam(in int n)
        {
            //keyword in dùng trong tham số hàm/method với ý nghĩa
            //ko cho code trong hàm thay đổi value của n. n trở thành
            //readonly

            //n chỉ có thể dùng để gán giá trị cho ai đó, bản thân n ko
            //đc mang giá trị mới

            //TODO AT HOME: với hàm có prototype dạng:
            //CheckReadOnlyParam(in Student x)
            //hỏi rằng x có  thể đc gán giá trị mới hay ko???
            //x là biến object, trỏ vùng new Student(...) kiến thức OOP

            Console.WriteLine($"Before modifying value, n is {n}");

            //n = 2024; //thay đổi valua của biến

            int x = n;
            Console.WriteLine($"After modifying value, for now n is {n}");


        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");

//            //xài thư viện/dll từ nơi khác, từ project khác 
//            //trong cùng solution, nhưng có thể khác namespace
//            //chú ý 3 việc
//            //1. add cái reference tới .ddl hay project cùng solution
//            //2. tick chọn cái option - VIP - 
//            //3. import/using cái namespace ở nơi chứa hàm mình sẽ xài
//            //xin phép, chi ra nơi chớn của thư viện/hàm sẽ xài
            
//            Console.WriteLine(BmiCalculator.EvaluateBmiStatus(BmiCalculator.GetBMI(70, 1.7)));

//            double bmi = BmiCalculator.GetBMI(70, 1.7);
//            string weightStatus = BmiCalculator.EvaluateBmiStatus(bmi);

//            Console.WriteLine(@$"Your BMI is {bmi} based on the
//your weight of {70} kg and
//   your height of {1.7} m.

//<html>
//   <head>
//   </head>
//   <body>
//    <footer>

//      Your weight status is {weightStatus}");

//    //kĩ thuật in chuỗi nguyên bản, có sao in vậy
//    //what you type is what you see in the screen
//    //raw string - VERBATIM - DÙNG KÍ TỰ @ ĐỨNG ĐẦU CHUỖI

//            Console.WriteLine("Press any key to exit...");
//            Console.ReadLine();
//        }
    }
}
