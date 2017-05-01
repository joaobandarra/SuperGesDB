using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class TiposEnvio
    {
        public TiposEnvio()
        {
            ListaEncomendas = new HashSet<Encomenda>();

        }

        [Key]
        public int ID { set; get; }

        [Required]
        [StringLength(20)]
        public string TipoEnvio { set; get; }


        // especificar que um cliente faz muitas encomendas
        public ICollection<Encomenda> ListaEncomendas { get; set; }
    }
}