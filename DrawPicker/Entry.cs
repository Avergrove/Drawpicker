using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPicker
{

    class Entry
    {
        private Person person;
        private Boolean selected;

        public Entry(Person person)
        {
            this.Person = person;
            this.Selected = false;
        }

        public bool Selected { get => selected; set => selected = value; }
        internal Person Person { get => person; set => person = value; }
    }
}
