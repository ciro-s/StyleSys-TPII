﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Categoria
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_categoria { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string cat_nombre { get; set; }

        [AllowNull]
        [StringLength(60)]
        public string cat_descripcion { get; set; }

        [Required]
        public bool cat_estado { get; set; }


        //public virtual ICollection<Producto> productos { get; set; }
    }
}