using Muffin.Entities.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Muffin.Entities
{
    public class Node : EntityBase
    {
        public string Name { get; set; }
        public string FdsnEventURL { get; set; }
        public string FdsnStationURL { get; set; }
        public string FdsnDataselectURL { get; set; }
        public string RoutingURL { get; set; }
    }
}
