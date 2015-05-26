using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj_chamadosBraWebAPI.Models
{
    [Table("Obras")]
    public class Obra
    {
        [Key]
        public Int32 IDO { get; set; }
        public string Descricao { get; set; }
    }
}