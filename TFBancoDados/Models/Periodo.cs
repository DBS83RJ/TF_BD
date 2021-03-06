﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFBancoDados.Models
{
    public class Periodo
    {
        [Key]
        [Required]
        public int Id_Periodo { get; set; }
        public ICollection<Possui> possui { get; set; }
        public ICollection<Pertence> pertence { get; set; }
    }
}
