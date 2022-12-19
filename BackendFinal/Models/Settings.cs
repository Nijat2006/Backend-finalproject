using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackendFinal.Models
{
    public class Settings
    {
        public int Id { get; set; }
        [StringLength(2500)]
        public string Key { get; set; }
        [StringLength(2500)]

        public string Value { get; set; }

    }
}
