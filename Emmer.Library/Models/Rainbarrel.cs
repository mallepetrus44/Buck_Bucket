using Emmer.Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emmer.Library.Models
{
    // alle regentonnen zijn containers
    public class Rainbarrel : Container
    {
        // regentonnen hebben een capacity van  80, 120, 160 vanuit een enum

        public Rainbarrel(RainBarrelSize rainBarrelSize) : this(rainBarrelSize, 0) { }

        public Rainbarrel(RainBarrelSize rainBarrelSize, int content)
        {
            Capacity = Convert.ToInt32(rainBarrelSize);
            if(content > Capacity)
            {
                content = Capacity;
            }
            Content = content;
        }
    }
}
