using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class EncomendaProduto
    {

        [Key]
        public int IDEncomendaProduto { get; set; }


        [Required]
        [StringLength(20)]
        public string NomeProduto { set; get; }

        [Required]
        public int Quantidade { set; get; }

        [Required]
        public double Preco { set; get; }

        [Required]
        [StringLength(3)]
        public string IVA { get; set; }

        // criar a chave forasteira
        // relaciona o objeto Encomenda com um objeto EncomendaProduto
        public virtual Encomenda Encomenda { get; set; }
        // relaciona o objeto Produto com um objeto EncomendaProduto
        public virtual Produto Produto { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Encomenda")]
        public int IDEncomendaFK { get; set; }

        [ForeignKey("Produto")]
        public int IDProdutoFK { get; set; }
    }
}