using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class RegiaoEnvio
    {

        [Key]
        public int IDRegiaoEnvio { set; get; }

        [Required]
        [StringLength(30)]
        public string NomeRegiao { set; get; }
    }
}