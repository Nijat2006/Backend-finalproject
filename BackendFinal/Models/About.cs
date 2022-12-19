using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal.Models
{
    public class About : BaseEntity
    {
        [StringLength(2500)]
        public string Name { get; set; }

      

    }
}
