using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class Imagens
    {

        [Key]
        public int ID { set; get; }

        public byte[] Fotografia { set; get; } //sem certeza desta situação (a resolver o problema)


        // relaciona o objeto Produto com um objeto Imagens
        public virtual Produto Produto { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Produto")]
        public int IDProdutoFK { get; set; }
    }
}