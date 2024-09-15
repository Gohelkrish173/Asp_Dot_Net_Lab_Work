//string Fname = "Krish";
//String Lname = "Gohel";

//int length = Fname.Length;
//Console.WriteLine(length);

//string joinedString = string.Concat(Fname,Lname);
//Console.WriteLine(joinedString);

//joinedString = string.Concat(joinedString, "Rajkot");
//Console.WriteLine(joinedString);

//Boolean result1 = Fname.Equals(Lname);
//Console.WriteLine(result1);

//string str = "This is the \"String\" class .";
//Console.WriteLine(str);

//bool check = Fname.Contains("kri");
//Console.WriteLine(check);

//string result = Fname.Substring(2);
//Console.WriteLine(result);
//string result2 = Fname.Substring(0,4);
//Console.WriteLine(result2);

//int compare = String.Compare(Fname, Lname);
//Console.WriteLine(compare);

//Console.WriteLine(Fname.ToLower());
//Console.WriteLine(Lname.ToUpper());
//Console.WriteLine(Fname.Insert(0,"_"));
//Console.WriteLine(Fname.LastIndexOf("h"));
//Console.WriteLine(Lname.Clone());

//try
//{
//    int n1 = Convert.ToInt32(Console.ReadLine());
//    int n2 = Convert.ToInt32(Console.ReadLine());

//    int n3 = n1 / n2;
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}

namespace LactureDemo.Evaluate
{
    class Program
    {
        public static void Main(string[] args) {

            int c = 0;

            c = Convert.ToInt16(Console.ReadLine());
            
            switch (c)
            {
                case 1:
                    Book B = new Book();

                    B.get();
                    Console.WriteLine("----------------");
                    B.display();
                    break;

                case 2:
                    Car car = new Car();

                    car.get();
                    Console.WriteLine("------------------");
                    car.display();
                    break;
                case 3:
                    Library l = new Library();
                    int x = 0;

                    while(x != -1){
                        int y = Convert.ToInt16(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                l.get();
                                break;
                            case 2:
                                l.display();
                                break;
                            case 3:
                                string s = Console.ReadLine();
                                l.search(s);
                                break;
                            case 4:x = -1;
                                break;
                        }
                    }
                    break;
                case 4:
                    EmployeeDepartment ed = new EmployeeDepartment();

                    ed.Display();
                    break;
                case 5:
                    Palindrome p = new Palindrome();

                    p.Pld("aba");
                    break;
                case 6:
                    lsstring LS = new lsstring();

                    LS.ls("Darshan University Rajkot Gujarat india");
                    break;
            }

        }
    }
}
