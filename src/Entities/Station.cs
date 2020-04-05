using Muffin.Entities.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muffin.Entities
{
    public class Station : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
