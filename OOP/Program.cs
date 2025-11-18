using System.ComponentModel;
using System.Drawing;

namespace OOP
{
    // public class Employee:IComparable, ICloneable
    // {
    //     // int id;
    //     string name;
    //     int age;
    //     // static int count;

    //     public int Id { get; set; }

    //     public int Age
    //     {
    //         set
    //         {
    //             age = value;
    //         }
    //         get
    //         {
    //             return age;
    //         }
    //     }

    //     public string Name { get; set; }

    //     // static Employee()
    //     // {
    //     //     count = 5;
    //     // }

    //     // public int count { get; set; }

    //     public override string ToString()
    //     {
    //         return $"Id:{Id}, Age:{Age}, Name:{Name}";
    //     }

    //     public int CompareTo(object? obj)
    //     {
    //         Employee emp = obj as Employee;
    //         if (Age.CompareTo(emp.Age) == 0)
    //         {
    //             return Name.CompareTo(emp.Name);
    //         }
    //         return Age.CompareTo(emp.Age);
    //     }
        
    //     public object Clone()
    //     {
    //         return new Employee{Id=this.Id, Age=this.Age, Name=this.Name};
    //     }

        
    // }

    // public static class MathHelper
    // {
    //     public static int Add(int num1, int num2)
    //     {
    //         return num1 + num2;
    //     }
    //     public static void AddRef(int num1, int num2, ref int res)
    //     {
    //         res = num1 + num2;
    //     }
    //     public static void AddOut(int num1, int num2, out int res)
    //     {
    //         res = num1 + num2;
    //     }
    // }

    #region Association
    // class Teacher 
    // {
    //     public void Teach(Student student)
    //     {
    //         Console.WriteLine($"{student.Name} is learning.");
    //     }
    // }

    // class Student
    // {
    //     public string Name { get; set; }
    // }
    #endregion

    #region Composition
    // class Room { }

    // class House
    // {
    //     private Room room;

    //     public House()
    //     {
    //         room = new Room();
    //     }

    //     public Room GetRoom()
    //     {
    //         return room;
    //     }
    // }
    #endregion

    // public static class Trial
    // {
    //     public static void Swap(ref int first, ref int last)
    //     {
    //         int temp = first;
    //         first = last;
    //         last = temp;
    //     }


    // }

    // public class MyStack<DT>
    // {
    //     DT[] arr;
    //     int size;
    //     int top;

    //     public MyStack()
    //     {
    //         size = 5;
    //     }
    //     public void Push(DT value)
    //     {
    //         values.Append(value);
    //     }
    // }

    // public class Repository
    // {
    //     public static List<Employee> GetEmployees { get; set; } =
    //     new List<Employee>()
    //     {
    //         new Employee(){Age = 22, Id = 1, Name = "amira"}
    //     };

    //     public override string ToString()
    //     {
    //         return base.ToString();
    //     }

    // }


    // public struct Location
    // {
    //     public int X { get; set; }
    //     public int Y { get; set; }
    //     public int Z { get; set; }

    //     public Location()
    //     {
    //         X = Y = Z = 0;
    //     }

    //     public Location(int _x, int _y, int _z)
    //     {
    //         X = _x;
    //         Y = _y;
    //         Z = _z;
    //     }

    //     public override string ToString()
    //     {
    //         return $"Location: ({X}, {Y}, {Z})";
    //     }

    // }

    // public class Football
    // {
    //     // publisher
    //     public int Id { get; set; }
    //     public Location ballLocation;
    //     public Location BallLocation
    //     {
    //         set
    //         {
    //             // if(ballLocation != null)
    //             // {
    //                 ballLocation = value;
    //                 ballLocationChanged?.Invoke();
    //             // }
    //         }
    //         get
    //         {
    //             return ballLocation;
    //         }
    //     }
    //     public event Action ballLocationChanged;
    // }

    // public class Player
    // {
    //     // Subscriber
    //     public string Name { get; set; }
    //     public string Team { get; set; }

    //     public void Run()
    //     {
    //         Console.WriteLine($"Player: {Name}, Clup: {Team}");
    //     }
    // }
    
    // public class Refers
    // {
    //     // Subscriber
    //     public string Name { get; set; }

    //     public void Observe()
    //     {
    //         Console.WriteLine($"Observe: {Name}");
    //     }
        
    // }








    internal class program
    {
        static void Main(String[] args)
        {

            #region Event
            Player p1_1 = new Player() { Name = "Ahmed", Team = "Ahly" };
            Player p2_1 = new Player() { Name = "Hassan", Team = "Ahly" };

            Player p1_2 = new Player() { Name = "Mohammed", Team = "Alex" };
            Player p2_2 = new Player() { Name = "Mostafa", Team = "Alex" };

            Refers r = new Refers() { Name = "Osama" };

            Football ball = new Football() { Id = 1, BallLocation = new Location() { X = 22, Y = 33, Z = 55 } };
            
            ball.ballLocationChanged += () => Console.WriteLine("Start ...");
            ball.ballLocationChanged += p1_1.Run;
            ball.ballLocationChanged += p2_1.Run;
            ball.ballLocationChanged += p1_2.Run;
            ball.ballLocationChanged += p2_2.Run;
            ball.ballLocationChanged += r.Observe;

            ball.BallLocation = new Location { X = 33, Y = 55, Z = 77 };

            #endregion





            #region Jagged array -- Rarely used
            // int[][] jaggedArr = new int[3][] { new int[3], new int[5] {1,2,3,4,5}, new int[2] };
            // foreach (int[] rows in jaggedArr)
            // {
            //     foreach (int col in rows)
            //     {
            //         Console.WriteLine("col:" + col);
            //     }
            //     Console.WriteLine("Row: " + rows);
            // }
            #endregion

            #region Find the longest distance between two equal cells
            // // int[] nums = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 }; // 8
            // int[] nums = { 1, 1, 1, 1, 1, 1 }; // 4
            // int maxDistance = 0, outputNum = -1;
            // for (int first = 0; first < nums.Length - 1; first++) 
            // {
            //     for (int last = first + 1; last < nums.Length; last++)
            //     {
            //         if ((nums[first] == nums[last]) && (maxDistance < last - first - 1))
            //         {
            //             maxDistance = last - first - 1; // 5
            //             outputNum = nums[first];
            //         }
            //     }
            // }
            // Console.WriteLine($"maxDistance: {maxDistance}, outputNum: {outputNum}");
            #endregion

            #region Reverse the order of the words
            // string text = Console.ReadLine(); // this is a test
            // string[] sentence = text.Split(' ');
            // List<string> reverseSentence = new List<string>();

            // for (int word = sentence.Length - 1; word >= 0; word--)
            // {
            //     reverseSentence.Add(sentence[word]);
            // }
            // Console.Write(string.Join(" ", reverseSentence)); // test a is this
            #endregion

            #region Count the occurrence of 1 from 1 to 99,999,999
            // int num = 99999999; // 99,999,999
            // int countZero = 0, countOne = 1;
            // while (num / 10 != 0)
            // {
            //     num = num / 10;
            //     countZero++;
            // }
            // for (int i = 0; i < countZero; i++)
            // {
            //     countOne = 10 * countOne;
            // }     
            // Console.WriteLine(countOne * (countZero + 1)); // 8000,000,0
            #endregion

            #region properities - Setter & Getter
            // Emp emp1 = new Emp();
            // emp1.Id = 20;
            // Console.WriteLine(emp1.Id);
            #endregion

            #region automatic properity 
            // Employee emp1 = new Employee();
            // emp1.Id = 20;
            // Console.WriteLine(emp1.Id);
            #endregion

            #region Static variable
            // Emp emp1 = new Emp();
            // emp1.Count = 10;
            // Emp emp2 = new Emp();
            // Console.WriteLine(emp2.Count);
            #endregion

            #region static method
            // Console.WriteLine(MathHelper.Add(3, 6));
            #endregion

            #region static ctr
            // Employee emp = new Employee();
            // emp.Count++;
            // Employee emp1 = new Employee();
            // System.Console.WriteLine(emp1.Count);
            #endregion

            #region property initializer
            // Employee emp1 = new Employee() { Id = 10, Age = 22, Name = "mira" };
            // Console.WriteLine(emp1.Age); // 22
            #endregion

            #region call by reference
            // int x = 3, y = 5, result;
            // MathHelper.AddOut(x, y, out result);
            // Console.WriteLine(result); // 8
            #endregion

            // int id = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(id);

            

            #region Sort Array of user-defined DT
            // Employee[] employees = new Employee[]
            // {
            //     new Employee{ Id = 1, Age = 22, Name = "amira" },
            //     new Employee{ Id = 2, Age = 11, Name = "mira" },
            //     new Employee{ Id = 3, Age = 22, Name = "moraa" }
            // };

            // Array.Sort(employees);
            // foreach(var emp in employees)
            // {
            //     Console.WriteLine(emp.ToString());
            // }
            #endregion

            #region Clone Object

            // int[] arr = { 1, 2, 3, 4, 5 };
            // int[] tmpArr = (int[])arr.Clone();
            // tmpArr[1] = 1000;
            // foreach (int i in arr)
            // {
            //     Console.WriteLine(i); // 1, 2, 3, 4, 5
            // }

            #endregion

            #region Clone Object of user-defined DT
            // Employee emp = new Employee { Id = 1, Age = 22, Name = "amira" };
            // Employee cloneEmp = emp.Clone() as Employee;
            // cloneEmp.Age = 33;
            // Console.WriteLine(emp.ToString()); // Id:1, Age:22, Name:amira
            #endregion

            #region Template
            // MyStack<int> stk = new MyStack<int>();
            // stk.Push(3);
            #endregion

            #region repository
            // var employees = Repository.GetEmployees;
            #endregion


        }
    }
}
