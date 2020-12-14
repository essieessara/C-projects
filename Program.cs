using System;

namespace lab_1
{

    class Program
    {
        enum position
        {
            Manager = 1,
            Technician = 2,
            Admin = 3
        }
        enum Jobtype
        {
            Part_time = 1,
            Full_time = 2
        }
        struct employee
        {
            public int empid;
            public string name;
            public position p;
            public float salary;
            public Jobtype j;

        }
        static void Fill_employee (out employee e)
        {
            Console.WriteLine("Enter Employee ID:");
            e.empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            e.name = (Console.ReadLine());
            Console.WriteLine("Enter Employee Salary:");
            e.salary = float.Parse(Console.ReadLine());
            int p;
            do
            {
                Console.WriteLine("Enter Employee position:Manager=1,Technician = 2,Admin = 3");
                p = int.Parse(Console.ReadLine());
            } while (p!=1&& p != 2&&p != 3);
            e.p = (position)p;
            int j;
            do
            {
                Console.WriteLine("Enter Employee Job:Part_time=1,Full_time = 2");
                j = int.Parse(Console.ReadLine());
            } while (j != 1 && j != 2);
            e.j = (Jobtype)j;
        }
        static void Fill_employee(employee e)
        {
            Console.WriteLine("Enter Employee ID:");
            e.empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            e.name = (Console.ReadLine());
            Console.WriteLine("Enter Employee Salary:");
            e.salary = float.Parse(Console.ReadLine());
            int p;
            do
            {
                Console.WriteLine("Enter Employee position:Manager=1,Technician = 2,Admin = 3");
                p = int.Parse(Console.ReadLine());
            } while (p != 1 && p != 2 && p != 3);
            e.p = (position)p;
            int j;
            do
            {
                Console.WriteLine("Enter Employee Job:Part_time=1,Full_time = 2");
                j = int.Parse(Console.ReadLine()); 
            } while (j != 1 && j != 2);
            e.j = (Jobtype)j;
        }

            
             static void print_Employee(employee e)
            {
                Console.WriteLine("Employee Id: {0}", e.empid);
                Console.WriteLine("Employee Name: {0}", e.name);
                Console.WriteLine("Employee Salary: {0}", e.salary);
                Console.WriteLine("Employee position: {0}", e.p);
                Console.WriteLine("Employee Jobtype: {0}", e.j);
            }

        public static void Main()
        {
            employee e;
            Fill_employee(out e);
            Fill_employee(e);
            print_Employee(e);
        }
    }

    }   
    
