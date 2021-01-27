using System;

namespace Emmer.Library.Models
{
    public abstract class Container
    {
        // emmer kan nooit minder dan 0 inhoud hebben (zie bodem)
        private const int MinumumContent = 0;

        // maximale inhoud container
        public int Capacity { get; set; }

        // Hoeveelheid in de container
        public int Content { get; set; }
        

        // Vullen met hoeveelheid
        public void Fill(int amount)
        {
            this.Content += amount;
        }


        // container is leeg
        public void Empty()
        {
            this.Content = MinumumContent;
        }


        // container legen met inhoud
        public void Empty(int amount)
        {          
            this.Content -= amount;
        }    
    }
}
