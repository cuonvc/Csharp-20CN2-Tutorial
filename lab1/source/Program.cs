using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source {
    internal class Program {
        static void Main(string[] args) {


            //example 1
            // Console.WriteLine("Nhap chuoi: ");
            // string str = Console.ReadLine();
            //
            // Console.WriteLine("Chuoi sau khi dao nguoc: ");
            // for (int i = str.Length - 1; i >= 0; i--) {
            //     Console.Write(str[i]);
            // }





            //example 2
            // Console.WriteLine("Nhap vao mot so nguyen: ");
            // int n = Console.Read();
            // for (int i = 0; i < n; i++) { 
            //
            // }






            //example 3
            // Console.WriteLine("Nhap vao chuoi thu nhat: ");
            // string str1 = Console.ReadLine();
            // Console.WriteLine("Nhap vao chuoi thu hai: ");
            // string str2 = Console.ReadLine();
            //
            // if (!str1.Equals(str2)) {
            //     Console.WriteLine("=======> Hai chuoi khong khop !");
            // } else {
            //     Console.WriteLine("=======> Hai chuoi bang nhau.");
            // }







            //example 4
            // do {
            //     Console.WriteLine("Nhap so thu nhat: ");
            //     double num1 = Convert.ToDouble(Console.ReadLine());
            //     Console.WriteLine("Nhap so thu hai: ");
            //     double num2 = Convert.ToDouble(Console.ReadLine());
            //     Console.WriteLine("Nhap phep toan: (+ - * /): ");
            //     string method = Console.ReadLine();
            //
            //     switch (method) {
            //         case "+":
            //             Console.WriteLine("Ket qua: " + (num1 + num2));
            //             break;
            //         case "-":
            //             Console.WriteLine("Ket qua: " + (num1 - num2));
            //             break;
            //         case "*":
            //             Console.WriteLine("Ket qua: " + (num1 * num2));
            //             break;
            //         case "/":
            //             if (num2 == 0) {
            //                 Console.WriteLine("Khong the chia cho 0");
            //                 break;
            //             }
            //             Console.WriteLine("Ket qua: " + (num1 / num2));
            //             break;
            //         default:
            //             Console.WriteLine("Phep tinh khong thoa man...");
            //             break;
            //
            //     }
            // } while (true);








            //example 5
            // Console.WriteLine("Nhap ban kinh hinh tron: ");
            // double r = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Chu vi: " + (2 * r * Math.PI));
            // Console.WriteLine("Dien tich: " + (Math.PI * r * r));







            //example 6
            // Console.WriteLine("Chon loai phuong trinh: ");
            // int level = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Nhap gia tri x: ");
            // int x = Convert.ToInt32(Console.ReadLine());
            //
            // switch (level) {
            //     case 1:
            //         Console.WriteLine("Nhap he so thu nhat: ");
            //         int a1 = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Nhap he so thu hai: ");
            //         int b1 = Convert.ToInt32(Console.ReadLine());
            //
            //         Console.WriteLine("Ket qua: " + (a1*x + b1));
            //         break;
            //
            //     case 2:
            //         Console.WriteLine("Nhap he so thu nhat: ");
            //         int a2 = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Nhap he so thu hai: ");
            //         int b2 = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Nhap he so thu ba: ");
            //         int c2 = Convert.ToInt32(Console.ReadLine());
            //
            //         Console.WriteLine("Ket qua: " + (a2*x*x + b2*x + c2));
            //         break;
            //
            //     case 3:
            //         Console.WriteLine("Nhap he so thu nhat: ");
            //         int a3 = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Nhap he so thu hai: ");
            //         int b3 = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Nhap he so thu ba: ");
            //         int c3 = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Nhap he so thu tu: ");
            //         int d3 = Convert.ToInt32(Console.ReadLine());
            //
            //         Console.WriteLine("Ket qua: " + (a3*x*x*x + b3*x*x + c3*x * d3));
            //         break;
            //
            //     default:
            //         Console.WriteLine("Khong ho tro ham bac " + level);
            //         break;
            // }



            


            //example 7
            // Console.WriteLine("Nhap quang duong (km): ");
            // double s = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Nhap thoi gian (h): ");
            // double t = Convert.ToDouble(Console.ReadLine());
            //
            // do {
            //     Console.WriteLine("Nhap don vi dau ra (m/s, km/h, mile/h): ");
            //     string type = Console.ReadLine();
            //     switch (type) {
            //         case "km/h":
            //             Console.WriteLine("Van toc dat duoc: " + (s / t) + "km/h");
            //             break;
            //
            //         case "m/s":
            //             double v2 = (s * 1000) / (t * 3600);
            //             Console.WriteLine("Van toc dat duoc: " + v2 + "m/s");
            //             break;
            //
            //         case "mile/h":
            //             double v3 = (s * 0.621371) / t;
            //             Console.WriteLine("Van toc dat duoc: " + v3 + "mile/h");
            //             break;
            //
            //         default: 
            //             Console.WriteLine("Not support");
            //             break;
            //     }
            // } while (true);










            //example 8
            // char[] chars = { 'a', 'e', 'i', 'o', 'u' };
            // Console.WriteLine("Nhap ki tu tu ban phim: ");
            // char c = Convert.ToChar(Console.ReadLine());
            // string newC = Char.ToString(c).ToLower();
            // c = Char.Parse(newC);
            //
            // if (chars.Contains(c)) {
            //     Console.WriteLine(c + " la mot nguyen am.");
            // } else if (Char.IsNumber(c)) {
            //     Console.WriteLine(c + " la mot number");
            // } else {
            //     Console.WriteLine(c + " khong la gi ca, mot character bo vo va co don giua hang ngan vi sao...");
            // }










            //example 9
            /*
            Console.WriteLine("Nhap vao mot so: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) {
                Console.WriteLine(number + " la mot so chan.");
            } else {
                Console.WriteLine(number + " la mot so le.");
            }
            */







            //example 10
            /*
            Console.WriteLine("Nhap so thap phan: ");
            double number = Convert.ToDouble(Console.ReadLine());
            List<int> binarys = new List<int>();
            do {
                int res = number % 2;
            } while (number == 1);
            */

            Console.Write("Nhap so nguyen: ");
            int rawNumber = Convert.ToInt32(Console.ReadLine());
            
            string res = Convert.ToString(rawNumber, 2);
            
            Console.WriteLine("Ket qua chuyen doi: " + res);

            Console.ReadKey();
        }
    }
}
