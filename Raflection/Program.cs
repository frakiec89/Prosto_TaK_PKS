using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Raflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();


            Type type = student.GetType();

            var members = type.GetFields(BindingFlags.NonPublic 
                | BindingFlags.Instance
                );

            foreach ( var  m in  members)
            {
                if (m.Name == "temp")
                {
                    var value = m.GetValue(student);

                    Console.WriteLine(value);

                    m.SetValue(student, 15);

                     value = m.GetValue(student);

                    Console.WriteLine(value);
                }
            }

            Console.Read();

        }


       
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private int temp;
    }
}
