using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Muffin.Entities.BaseClasses;

namespace Muffin.Entities
{
    public class Event : FdsnEntityBase
    {
        public DateTime? Time { get; set; }
    }
}
