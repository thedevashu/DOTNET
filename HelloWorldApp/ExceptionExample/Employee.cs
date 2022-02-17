using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExample
{
    class Employee
    {
        private int _id;
        private string _empName;
        private float _sal;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string EmpName
        {
            get { return this._empName; }
            set { this._empName = value; }
        }
        public float Salary
        {
            get { return this._sal; }
            set { this._sal = value; }
        }

        public Employee()
        {
            Console.WriteLine("public Employee() called....");
        }

        public Employee(int id,string name,float sal):this()
        {
            Console.WriteLine("public Employee(int id,string name,float sal) called....");
            this._id = id;
            this._empName = name;
            this._sal = sal;
        }
    }
}
