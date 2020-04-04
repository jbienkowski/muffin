using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Muffin.Entities.BaseClasses;

namespace Muffin.Entities
{
    public class Event : FdsnEntityBase
    {
        [MaxLength(50)]
        public DateTime? Time { get; set; }
    }
}
