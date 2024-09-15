using System;
using System.Collections;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using DemoConsole;
using DemoConsole.Lab_2;
using DemoConsole.Lab_3;
using DemoConsole.LecturePractice;

delegate int df(int a);
delegate void TraficDel();
delegate double CalcDel<T1, T2>(T1 a,T2 b);

namespace DemoConsole.Lab_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select Lab No.(1 to 4) : ");
            int Chose = Convert.ToInt32(Console.ReadLine());

            switch (Chose)
            {
                case 1:
                    Console.WriteLine("choce Lab-1 program no.");
                    int c1 = Convert.ToInt16(Console.ReadLine());

                    switch (c1)
                    {
                        case 1:
                            Candidate s1 = new Candidate();

                            s1.GetCandidateDetail();
                            s1.DisplayCandidateDetail();
                            break;
                        case 2:
                            Staff[] S = new Staff[5];

                            for (int i = 0; i < S.Length; i++)
                            {
                                S[i] = new Staff();
                                S[i].GetDetail();
                            }

                            for (int i = 0; i < S.Length; i++)
                            {
                                if (S[i].Designation == "HOD")
                                {
                                    S[i].DisplayDetail();
                                }
                            }
                            break;
                        case 3:
                            Bank_Account BA1 = new Bank_Account();

                            BA1.GetAccountDetails();
                            BA1.DisplayAccountDetails();
                            break;
                        case 4:
                            Student Smain = new Student(22010101060, "krish", 5, 8.48, 8.48);
                            Student S1 = new Student("krish");

                            Smain.DisplayStudentDetail();
                            S1.DisplayStudentDetail();
                            break;
                        case 5:
                            RectangleArea x = new RectangleArea(10, 10);

                            x.DisplayArea();
                            break;
                        case 6:
                            Interest I = new Interest();

                            I.GetDetails();
                            Console.WriteLine(I.DisplayInterest());
                            break;
                        case 7:
                            Salary salary = new Salary(500000, 100000);
                            salary.CalculateSalary();
                            break;
                        case 8:
                            Distance a = new Distance(10, 20, 30);
                            Distance b = new Distance(20, 30, 40);

                            double x1 = a.dist1 + b.dist1;
                            double x2 = a.dist2 + b.dist2;
                            double x3 = a.dist3 + b.dist3;

                            Distance d = new Distance();

                            d.addoutput(x1, x2, x3);
                            Console.WriteLine("Added Output in to third Object is :");
                            d.DisplayOutput();
                            break;
                        case 9:
                            Furniture f = new Furniture();

                            f.GetDetail();
                            Console.WriteLine("--------------");
                            f.DisplayFurnitureDetail();
                            break;
                        case 10:
                            Salary1 S2 = new Salary1();
                            S2.Disp_sal();
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("choce Lab-1 program no.");
                    int c2 = Convert.ToInt16(Console.ReadLine());

                    switch (c2)
                    {
                        case 1:
                            DivideZeroExce d = new DivideZeroExce();
                            try
                            {
                                d.getDetail();
                            }
                            catch (DivideByZero e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        
                        case 2:
                            Staff[] S = new Staff[5];

                            for (int i = 0; i <= 5; i++)
                            {
                                try
                                {
                                    S[i] = new Staff();
                                    S[i].GetDetail();
                                }
                                catch (IndexOutOfRangeException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            break;
                        
                        case 3:
                            Calculate C1 = new Calculate();

                            Console.WriteLine("Sum Of Two : " + C1.SumOfTwo(5, 10));

                            Calculate C2 = new Calculate();
                            Console.WriteLine("Sum Of Three : " + C2.SumOfThree(5, 10, 20));
                            break;
                        
                        case 4:
                            Result R = new Result();

                            R.GetVal();

                            switch (R.choice)
                            {
                                case "+":
                                    Console.WriteLine(R.Addition(R.A, R.B));
                                    break;
                                case "-":
                                    Console.WriteLine(R.Subtraction(R.A, R.B));
                                    break;
                            }
                            break;

                        case 5:
                            string s = "krish Gohel";
                            Console.WriteLine("ToUpperCase : " + s.ToUpper());
                            Console.WriteLine("ToLowerCase : " + s.ToLower());
                            Console.WriteLine("String Length : " + s.Length);
                            Console.WriteLine("Contains : " + s.Contains("i"));
                            Console.WriteLine("Replace " + s.Replace("i", "I"));
                            String[] x = s.Split("i");
                            Console.WriteLine("Split : S1 =" + x[0] + ", S2 =" + x[1]);
                            Console.WriteLine("Compare -> S1 == S2 :" + x[0].CompareTo(x[0]));
                            Console.WriteLine("Normalization : " + s.Normalize());
                            Console.WriteLine("Append (Append char in sequence at end) : " + s.Append('G'));
                            Console.WriteLine("Clone : " + s.Clone());
                            Console.WriteLine("ToCharArray (string convert to char array) : " + s.ToCharArray()[0] + s.ToCharArray()[1]);
                            Console.WriteLine("EndsWith (return bool) :" + s.EndsWith('l'));
                            Console.WriteLine("Equals" + s.Equals(x[0]));
                            Console.WriteLine("GetType : " + s.GetType());
                            Console.WriteLine("Index of char : " + s.IndexOf('G'));
                            Console.WriteLine("char[] exist in string : " + s.IndexOfAny(['a', 'e', 'o', 'i', 'u']));
                            Console.WriteLine("Insert : " + s.Insert(11, " Vishal Bhai"));
                            Console.WriteLine("Remove : " + s.Remove(9));
                            Console.WriteLine("Substring : " + s.Substring(8));
                            Console.WriteLine("Trim : " + s.Trim());
                            break;
                        
                        case 6:
                            Console.WriteLine("Enter A : ");
                            string A = Console.ReadLine();
                            char[] a = A.ToCharArray();
                            char[] b = new char[a.Length];
                            string st = "";

                            for (int i = 0; i < a.Length; i++)
                            {
                                Console.WriteLine((int)a[i]);
                                if ((int)a[i] >= 97 && (int)a[i] <= 122)
                                {
                                    st += a[i].ToString().ToUpper();
                                    Console.WriteLine("-----" + st);
                                }
                                else
                                {
                                    st += a[i].ToString().ToLower();
                                }
                            }

                            Console.WriteLine(st);
                            break;
                        case 7:
                            Area A1 = new Area();

                            Console.WriteLine(A1.Circle(5.5));
                            Console.WriteLine(A1.Triangle(10.5, 11.2));
                            Console.WriteLine(A1.Square(10.5));
                            break;
                        
                        case 8:
                            try
                            {
                                int n = Convert.ToInt16(Console.ReadLine());
                                if (n % 2 == 0)
                                {
                                    throw new EvenException("Entered Number is Even.");
                                }
                            }
                            catch (EvenException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case 9:
                            String A3 = Console.ReadLine();
                            String[] B = A3.Split(" ");
                            String temp = "";

                            for (int i = 0; i < B.Length; i++)
                            {
                                temp = B[i];
                                if (temp.Length > B[i].Length)
                                {
                                    temp = B[i];
                                }
                            }
                            Console.WriteLine(temp);
                            break;

                        case 10:
                            Console.WriteLine("Enter only single char : ");
                            String a2 = Console.ReadLine();

                            if ((int)a2[0] >= 97 && (int)a2[0] <= 127)
                            {
                                Console.WriteLine(a2.ToUpper());
                            }
                            else
                            {
                                Console.WriteLine(a2.ToLower());
                            }
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("choce Lab-1 program no.");
                    int c3 = Convert.ToInt16(Console.ReadLine());

                    switch (c3)
                    {
                        case 1:
                            Add A1 = new Add();

                            Console.WriteLine("int addition : " + A1.Addition(5, 2));
                            Console.WriteLine("float addtion : " + A1.Addition(5.2f, 2.5f));
                            break;
                        case 2:
                            CalculateArea CA = new CalculateArea();

                            Console.WriteLine("Area Of Rectangle : " + CA.Area(10.5, 5));

                            Console.WriteLine("Area Of Square : " + CA.Area(5.5));
                            break;
                        case 3:
                            ICICI e1 = new ICICI();
                            HDFC e2 = new HDFC();
                            SBI e3 = new SBI();
                            RBI e = new RBI();

                            Console.WriteLine("Interest in ICIC : " + e1.CalculateInterest(1000, 5));
                            Console.WriteLine("Interest in HDFC : " + e2.CalculateInterest(1000, 5));
                            Console.WriteLine("Interest in SBI : " + e3.CalculateInterest(1000, 5));
                            Console.WriteLine("Interest in RBI : " + e.CalculateInterest(1000, 5));
                            break;
                        case 4:
                            factorial f1 = new factorial();

                            df f = new df(f1.fact);
                            //or df f = f1.fact;

                            Console.WriteLine("factorial :" + f(5));
                            break;
                        case 5:
                            Hospital hospital = new Hospital();
                            Wockhart wock = new Wockhart();
                            Gokul_superspecialist GS = new Gokul_superspecialist();
                            Apollo A2 = new Apollo();

                            hospital.HospitalDetails("Civil", 9.5);
                            Console.WriteLine("----------------------");
                            wock.HospitalDetails("Wockhart", 8);
                            Console.WriteLine("----------------------");
                            GS.HospitalDetails("Gokul", 6.5);
                            Console.WriteLine("----------------------");
                            A2.HospitalDetails("Apollo", 7.5);
                            break;

                        case 6:
                            CalArea Area = new CalArea();

                            Console.WriteLine("Area of Circle : " + Area.area(5.5) + "\n ---------------------------------------------");
                            Console.WriteLine("Area of Square : " + Area.area(5.0) + "\n ---------------------------------------------");
                            Console.WriteLine("Area of Rectangle : " + Area.area(5.5, 2.5));
                            break;

                        case 7:
                            TraficSignal ts = new TraficSignal();

                            TraficDel Y = new TraficDel(ts.Yellow);
                            TraficDel R = new TraficDel(ts.Red);
                            TraficDel G = new TraficDel(ts.Green);

                            Y();
                            R();
                            G();
                            break;

                        case 8:
                            delCalculate CC = new delCalculate();

                            CalcDel<double, double> X = new CalcDel<double, double>(CC.addition);
                            CalcDel<double, double> Y1 = new CalcDel<double, double>(CC.subtract);
                            CalcDel<double, double> Z = new CalcDel<double, double>(CC.multiply);
                            CalcDel<double, double> A = new CalcDel<double, double>(CC.divide);

                            Console.WriteLine("divide : " + A(10, 20));
                            Console.WriteLine("multy : " + Z(10, 20));
                            Console.WriteLine("Subtract : " + Y1(10, 20));
                            Console.WriteLine("Divide : " + X(10, 20));
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("choce Lab-1 program no.");
                    int c4 = Convert.ToInt16(Console.ReadLine());

                    switch (c4)
                    {
                        case 1:
                            ArrayList StudentName = new ArrayList();

                            //Console.WriteLine("Enter Your Choice : ");
                            //int choice = Convert.ToInt32(Console.ReadLine());

                            StudentName.Add("krish Gohel");
                            StudentName.Add("Mehul Parmar");
                            StudentName.Add("Sachin");
                            StudentName.Remove("Mehul Parmar");
                            StudentName.Add("sandip");
                            StudentName.Add("varma");
                            StudentName.Add("Rutvik");
                            StudentName.RemoveRange(1, 3);
                            StudentName.Clear();

                            for (int i = 0; i < StudentName.Count; i++)
                            {
                                Console.WriteLine(StudentName[i]);
                            }
                            break;

                        case 2:
                            List<string> StudentName1 = new List<string>();

                            StudentName1.Add("krish");
                            StudentName1.Add("Mehul");
                            StudentName1.Add("Sachin");
                            StudentName1.Add("varma");
                            StudentName1.Add("Rutvik");
                            StudentName1.Remove("varma");
                            StudentName1.RemoveRange(2, 2);
                            StudentName1.Clear();

                            for (int i = 0; i < StudentName1.Count; i++)
                            {
                                Console.WriteLine(StudentName1[i]);
                            }
                            break;

                        case 3:
                            Stack<int> S = new Stack<int>();

                            S.Push(10);
                            S.Push(20);
                            S.Push(30);
                            S.Push(40);
                            S.Push(50);

                            S.Pop();
                            S.Pop();
                            S.Clear();

                            Console.WriteLine("Use of peek : " + S.Peek());
                            Console.WriteLine("Use of Contains : " + S.Contains(20));


                            foreach (int k in S)
                            {
                                Console.WriteLine(k);
                            }
                            break;

                        case 4:
                            Queue<int> Q = new Queue<int>();

                            Q.Enqueue(10);
                            Q.Enqueue(100);
                            Q.Enqueue(1000);
                            Q.Enqueue(10000);
                            Q.Enqueue(100000);

                            Q.Dequeue();

                            Q.Clear();

                            Console.WriteLine("Use of peek :" + Q.Peek());
                            Console.WriteLine("Use of Contains : " + Q.Contains(1000));

                            foreach (int q in Q)
                            {
                                Console.WriteLine(q);
                            }
                            break;
                    }
                    break;
            }
        }
    }
}