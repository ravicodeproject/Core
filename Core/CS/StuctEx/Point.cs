using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CS.StuctEx
{
    // this calls the default parameterless constructor that initializes all the members to their default value.
    struct Employee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;
    }

    struct Employee2
    {
        public int EmpId;
        public string FirstName;
        public string LastName;

        public Employee2(int empid, string fname, string lname)
        {
            EmpId = empid;
            FirstName = fname;
            LastName = lname; //'Employee2.LastName' must be fully assigned before control is returned to the caller

        }
    }

    struct Point
    {
        int _x, _y;

        public int X { get { return _x; } set  { _x = value; PointChanged(_x); } }
        public int Y { get { return _y; } set { _y = value; PointChanged(_y); } }

        public event Action<int> PointChanged;
    }

    class ProgramTest
    {
        public  void structeventhandler(int point)
        {
            Console.WriteLine("Point changed to {0}",point);
        }

        public static void structevent(int point)
        {
            Console.WriteLine("Point changed to {0}", point);
        }

        public static void run()
        {
            ProgramTest pt = new ProgramTest();           


            Point point = new Point();
            //point.PointChanged += pt.structeventhandler;
            point.PointChanged += structevent;
            point.X = 10;
            point.Y = 20;


            Employee e = new Employee();

            Console.WriteLine(e.EmpId);
            Console.WriteLine(e.FirstName);
            Console.WriteLine(e.LastName);

            Employee2 emp = new Employee2(10, "Bill", "Gates");

            Console.Write(emp.EmpId); // prints 10  
            Console.Write(emp.FirstName); // prints Bill  
            Console.Write(emp.LastName); // prints Gates  

        }
    }
}
