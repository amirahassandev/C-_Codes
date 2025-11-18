using System.Runtime.InteropServices;

namespace TestCodes
{
    public delegate bool delCheckItem(int x, int y);
    public delegate void delChain(string input);

    public delegate int delCalc(int num1, int num2);



    internal class program
    {
        static void Main(String[] args)
        {
            #region Delegate
            // static List<int> GetFiltredValues(List<int> items, int num, delCheckItem del)
            // {
            //     List<int> result = new List<int>();
            //     foreach (int item in items)
            //     {
            //         if (del(item, num))
            //         {
            //             result.Add(item);
            //         }
            //     }
            //     return result;
            // }

            // delCheckItem delIsGreater = (int x, int y) => x > y;
            // delCheckItem delIsLess = (int x, int y) => x < y;
            // delCheckItem delIsEqual = (int x, int y) =>  x == y;


            // var output = GetFiltredValues([1, 2, 4, 6, 5, 8, 9, 11], 5, delIsEqual);
            // foreach(int item in output)
            // {
            //     Console.WriteLine(item);
            // }


            // ################ ######################//
            // Console.WriteLine(Calculate(3, 4, (num1, num2) => num1 + num2));

            // static int Calculate(int num1, int num2, delCalc op){
            //     return op(num1, num2);
            // }


            #endregion

            #region Delegate Chain

            // delChain del = Method1;
            // del += Method2;
            // del += Method3;

            // del("My input");



            // static void Method1(string input)
            // {
            //     Console.WriteLine($"Method1 + {input}");
            // }

            // static void Method2(string input)
            // {
            //     Console.WriteLine($"Method2 + {input}");
            // }

            // static void Method3(string input)
            // {
            //     Console.WriteLine($"Method3 + {input}");
            // }
            #endregion


            #region EventHandler
            // VideoYoutubeChannel video = new VideoYoutubeChannel();
            // Subscriber subscriber1 = new Subscriber();
            // Subscriber subscriber2 = new Subscriber();
            // Subscriber subscriber3 = new Subscriber();
            // Subscriber subscriber4 = new Subscriber();

            // subscriber1.subscribe(video);
            // subscriber2.subscribe(video);
            // subscriber3.subscribe(video);

            // video.uploadVideo(new VideoInfo{videoId = 1, videoTitle = "v1", videoDesc = "v1_desc"});
            #endregion


            #region indexer

            // BookCollection bookCollection = new BookCollection();
            // bookCollection[0] = new Book { id = 1, title = "t1", authour = "a1" };
            // bookCollection[1] = new Book { id = 2, title = "t2", authour = "a2" };


            // Console.WriteLine(bookCollection["t1"].id);


            #endregion

            #region Extension Method
            // ########### NumberHelpers ##############
            // int percentage = 20;
            // Console.WriteLine(percentage.IsBetween(0, 100));

            // ########### StringHelpers ##############
            // string str = "Hello Moraa :) ";
            // Console.WriteLine(str.RemoveWhiteSpace().ReverseStr());

            #endregion

            #region IEnumarable & IEnumerator
            // Employee emp = new Employee(){Name = "e1"};
            // emp.AddPayItem("pay1", 2000);
            // emp.AddPayItem("pay2", 100);
            // emp.AddPayItem("pay3", -300);

            // foreach(var payItem in emp)
            // {
            //     Console.WriteLine($"name: {payItem.Name}, value: {payItem.Value}");
            // }

            // var enumerator = emp.GetEnumerator();
            #endregion

            #region LINQ
            // List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9};
            // var result = (from num in numbers where num > 7 select num).ToList();
            // foreach(var item in result)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("-------------------------------");

            // numbers.AddRange(new int[] {12, 13, 14, 15});
            // foreach(var item in result)
            // {
            //     Console.WriteLine(item); 
            // }

            #endregion



            #region Operator overloading
              // ###########      Addition        ########### // 
            // Complex left = new Complex(){ Real = 22, Img = 3 };
            // Complex right = new Complex(){ Real = 10, Img = 2 };
            // Complex result = left + right;
            // Console.WriteLine(result.ToString()); // 32+5i

            // ###########      Incremental        ########### // 
            // Complex com = new Complex() { Real = 22, Img = 3 };
            // Console.WriteLine(com.ToString()); // 22+3i
            // Complex resultIncrement = com++;
            // Console.WriteLine(com.ToString()); // 23+4i
            // Console.WriteLine(resultIncrement.ToString()); // 22+3i

            // ##########      Check        ########### // 
            // Complex left = new Complex(){ Real = 22, Img = 3 };
            // Complex right = new Complex() { Real = 10, Img = 2 };
            // bool resultGreater = left > right;
            // bool resultLess = right < left;
            // bool resultEqual = right == left;
            // bool resultNotEqual = right != left;

            // Console.WriteLine(resultGreater.ToString()); // True
            // Console.WriteLine(resultLess.ToString()); // True
            // Console.WriteLine(resultEqual.ToString()); // False
            // Console.WriteLine(resultNotEqual.ToString()); // True

            // ##########      Implicit & Explicit        ########### // 
            // Complex com = new Complex() { Real = 22, Img = 3 };
            // int real = com;
            // string comExplicit = (string)com;
            // Console.WriteLine(real); // 22
            // Console.WriteLine(comExplicit); // 22+3i

            // Complex com1 = 6;
            // Console.WriteLine(com1.ToString()); // 6+0i

            #endregion

            #region Record
            // Student std = new Student("Amira", 22, new Address(){City = "Cairo", StreetName = "Nasir"});
            // // std.address = null; // HERE => You Can NOT Edit It
            // std.address.City = "Alex"; // HERE => You Can Edit It
            // Console.WriteLine(std.address.ToString());

            #endregion











            // Console.ReadKey();


        }


    }
}
