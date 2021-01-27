using System;
using System.Collections.Generic;
using System.Text;

namespace Emmer.Library.Models
{
    // Alle olievatten zijn containers
    public class Oildrum : Container
    {
        // een Olievat is altijd 159 (zolang het programma draait)
        private const int OildrumCapacity = 159;

        public Oildrum (): this(0, OildrumCapacity) { }

        public Oildrum (int content) : this(content, OildrumCapacity) { }

        public Oildrum (int content, int capacity)
        {
            Content = content;
            Capacity = OildrumCapacity;
        }
    }
}
