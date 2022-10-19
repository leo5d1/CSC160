using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Classes
    {
        public static void Execute()
        {
            ExampleProperties ep = new ExampleProperties();

            ep.prop2 = "stuff";

            ep.GetProp3 = "prop 3 stuff";
            string s3 = ep.GetProp3;


            Math math = new Math();
            float area = 2 * Math.PI * 2.0f;
            area = Math.CalcArea(area);
            area = math.CalcWidth(area);

            Student milton = new Student();
            milton.Name = "Milton";
            Console.WriteLine("Students name is {0}", milton.Name);
        }
    }

    class Student
    {
        protected string name;
        protected int cohort = 37;
        protected float gpa;
        static int NumberOfStudents = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4.0)
                {
                    gpa = value;
                }
            }
        }

        // auto-implemented property - auto creates a private field only acessable through get/sets
        // could remove get or set
        public int Age { get; set; } = 21;

        public Student()
        {
            Age = 26;
            Name = "Bob";
            Console.WriteLine("In Student constructor 0 params");
            NumberOfStudents++;
        }

        public Student(string name, int cohort, float gpa, float gPA, int age)
        {
            Name = name;
            this.cohort = cohort;
            this.gpa = gpa;
            Name = name;
            GPA = gPA;
            Age = age;
            NumberOfStudents++;
            Console.WriteLine("student constructor with all params");
        }

        public void HowManyStudents()
        {
            Console.WriteLine("Number of Students {0}", NumberOfStudents);
        }
    }

    class Math // if static class, forces all methods in it to be static
    {
        public const float PI = 3.14159f; // cannot be changed after creation
        
        // static classes do not need instantiation
        public static float CalcArea(float radius)
        {
            return 2 * PI * radius;
        }

        public float CalcWidth(float f)
        {
            return f;
        }
    }

    class ExampleProperties
    {
        public string prop2; // quick and easy, but saving loading not validated
        private string prop3; // better - create private variables, control access with properties

        public string GetProp3
        {
            get { return prop3; }
            set { prop3 = value; }
        }
    }
}
