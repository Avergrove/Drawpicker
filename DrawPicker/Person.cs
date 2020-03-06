using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPicker
{


    class Person
    {
        private static int cumulativeId = 0;
        private int id;
        private String name;

        public Person(string name)
        {
            this.Id = ++cumulativeId;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
