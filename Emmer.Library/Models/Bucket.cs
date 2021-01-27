namespace Emmer.Library.Models
{
    // Alle emmers zijn containers
    public class Bucket : Container
    {
        /// <summary>
        ///                         Constructor chaining (aanmaken emmers op basis van geen, één of twee parameters)
        ///                         Als de "capacity" niet wordt aangegeven dan is het de defaultwaarde
        ///                         Er kan nooit een emmer kleiner dan 10 aangemaakt worden
        /// </summary>
        /// 

        
        // de standaard grote van een emmer is 12 
        const int CapacityDefault = 12;

        // minimale inhoud voor een emmer is 10
        const int CapacityMinumum = 10;
  

        // Chaining
        public Bucket() : this(0, CapacityDefault) { }
   
        public Bucket(int content) : this(content, CapacityDefault) { }
    
        public Bucket(int content, int capacity)
        {
            this.Content = content;

            // de grote van de emmer is minumaal het "Capacityminumum", tenzij de waarde van "capacity" boven het "CapacityMinumum" ligt 
            if(capacity >= CapacityMinumum)
            {
                this.Capacity = capacity;
            }
            this.Capacity = CapacityMinumum;
        }



        /// <summary>
        ///                         Een emmer kan alleen door een andere emmer gevuld worden
        /// </summary>
        /// <param name="bucket">   Een emmer kan alleen een andere emmer vullen                </param>

        public void Fill(Bucket bucket)
        {
            // deze emmer vullen met inhoud van de andere
            this.Content += bucket.Content;

            // hoeveel ruimte is er nog over?
            int SpaceLeftOver = this.Capacity - this.Content;

            //ruimte over in de eemer die vult
            bucket.Content -= SpaceLeftOver;
        }   
    }
}
