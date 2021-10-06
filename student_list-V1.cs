using System;
using System.Collections.Generic;

namespace Lab_1
{
    class Student_grup
    {   

       public List<string> FIO = new List<string>() {"Вавилов Александр Викторович","Ершов Василий Пупкин" };
       public List<string> Phone_number = new List<string>() {"+79128027650","+79823258190" };
       public List<string> Date = new List<string>() {"17.12.2002", "10.10.1999" };



       public void Search()//Function for search student
       {
            Console.WriteLine("Enter index:\n-FIO\n-Date\n-Number\n----------------\n");
            string flag = Console.ReadLine();
            string indexS;
            switch (flag)
            {
                case "-FIO"://Search by FIO
                    Console.WriteLine("Enter FIO");
                    indexS = Console.ReadLine();
                    Console.WriteLine("\n");
                    for (int i = 0; i < FIO.Count; i++)
                    {
                        if (FIO[i] == indexS)
                        {
                            Console.WriteLine("FIO:   " + FIO[FIO.IndexOf(indexS)]);
                            Console.WriteLine("Phone: " + Phone_number[FIO.IndexOf(indexS)]);
                            Console.WriteLine("Date:  " + Date[FIO.IndexOf(indexS)]);
                            Console.WriteLine("\n");
                            return;
                        }

                    }
                    Console.WriteLine(indexS + " Not found.");
                    break;

                case "-Date"://Search by date of birth
                    Console.WriteLine("Enter Date");
                    indexS = Console.ReadLine();
                    Console.WriteLine("\n");
                    for (int i = 0; i < FIO.Count; i++)
                    {
                        if (Date[i] == indexS)
                        {
                            Console.WriteLine("FIO:   " + FIO[Date.IndexOf(indexS)]);
                            Console.WriteLine("Phone: " + Phone_number[Date.IndexOf(indexS)]);
                            Console.WriteLine("Date:  " + Date[Date.IndexOf(indexS)]);
                            Console.WriteLine("\n");
                            return;
                        }

                    }
                    Console.WriteLine(indexS + " Not found.");
                    break;

                case "-Number"://Search by phone number
                    Console.WriteLine("Enter Phone");
                    indexS = Console.ReadLine();
                    Console.WriteLine("\n");
                    for (int i = 0; i < FIO.Count; i++)
                    {
                        if (Phone_number[i] == indexS)
                        {
                            Console.WriteLine("FIO:   " + FIO[Phone_number.IndexOf(indexS)]);
                            Console.WriteLine("Phone: " + Phone_number[Phone_number.IndexOf(indexS)]);
                            Console.WriteLine("Date:  " + Date[Phone_number.IndexOf(indexS)]);
                            Console.WriteLine("\n");
                            return;
                        }

                    }
                    Console.WriteLine(indexS + " Not found.");
                    break;

            }
        }

       void Add_stud()//Add student in list
       {

            Console.WriteLine("Enter student FIO:");
            FIO.Add(Console.ReadLine());
            Console.WriteLine("Enter student phone number:");
            Phone_number.Add(Console.ReadLine());
            Console.WriteLine("Enter student birth day:");
            Date.Add(Console.ReadLine());
            Sort_list();
       }

       void Delite_stud()//Delite student
       {
            Console.WriteLine("Enter student FIO to delete:");
            string FIO_stud = Console.ReadLine();
            int index = -1;
            for (int i = 0; i < FIO.Count; i++)
            {
                if (FIO[i] == FIO_stud)
                {
                    index = i;
                    break;
                }
                    
            }
            if (index < 0)
            {
                Console.WriteLine("Not found!");
                return;
            }
            FIO.RemoveAt(index);
            Phone_number.RemoveAt(index);
            Date.RemoveAt(index);
            Sort_list();
            Console.WriteLine("Delite complite: " + FIO_stud);

       }

       public void Sort_list()//Sort student list
       {
            bool flag = false;
            for (int i = 0; i < FIO.Count - 1; i++)
            {
                for (int j = i; j < FIO.Count; j++)
                {
                    string container = Date[i];
                    int f1 = Convert.ToInt32(container.Split(".")[2]);
                    container = Date[j];
                    int f2 = Convert.ToInt32(container.Split(".")[2]);
                    if (f1 > f2)
                    {
                        container = FIO[i];
                        string date = Date[i];
                        string phone = Phone_number[i];
                        FIO[i] = FIO[j];
                        Date[i] = Date[j];
                        Phone_number[i] = Phone_number[j];
                        FIO[j] = container;
                        Date[j] = date;
                        Phone_number[j] = phone;
                        flag = true;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Sort list: Complete.");
            }
            
       }

       public void Out_list()
       {
            for (int i = 0; i < FIO.Count; i++)
            {
                Console.WriteLine("№" + (i+1));
                Console.WriteLine("FIO:   " + FIO[i]);
                Console.WriteLine("Phone: " + Phone_number[i]);
                Console.WriteLine("Date:  " + Date[i]);
                Console.WriteLine("\n");
            }
       }

       public void Handler()//Index handler for managing student list 
       {
            Console.WriteLine("Enter index:\n-S - search\n-Add - Add student\n-Del - delite student\n-Sort - sort list\n-Out - output list\n----------------\n");
            string index = Console.ReadLine();
            switch (index)
            {
                case "-S":
                    Search();
                    break;
                case "-Add":
                    Add_stud();
                    break;
                case "-Del":
                    Delite_stud();
                    break;
                case "-Sort":
                    Sort_list();
                    break;
                case "-Out":
                    Out_list();
                    break;
            }
       }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            bool flagg = true;
            Student_grup K1 = new Student_grup();
            while (flagg)
            {
                K1.Handler();
                Console.WriteLine("Enter 'exit' if you want close program.\nIf you want continue, you nead press 'Enter'\n----------------\n");
                string f = Console.ReadLine();
                if (f == "exit")
                    flagg = false;
                Console.Clear();
            }
        }
    }
}
