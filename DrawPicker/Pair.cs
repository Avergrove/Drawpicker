using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPicker
{
    class Pair<T>
    {
        private T valA;
        private T valB;

        public T ValA { get => valA; set => valA = value; }
        public T ValB { get => valB; set => valB = value; }

        public Pair(T valA, T valB)
        {
            this.ValA = valA;
            this.ValB = valB;
        }
    }
}