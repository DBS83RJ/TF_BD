﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFBancoDados.Models
{
    public class Sala
    {
        [Key]
        [Required]
        public int Id_Sala { get; set; }
    }
}