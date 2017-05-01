using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class CarrinhoComprasProduto
    {

        [Key]
        public int IDCarrinho { get; set; }
        [Key]
        public int IDProduto { get; set; }

        // criar a chave forasteira
        // relaciona o objeto CarrinhoCompras com um objeto CarrinhoComprasProduto
        public virtual CarrinhoCompras CarrinhoCompras { get; set; }
        // relaciona o objeto Produto com um objeto CarrinhoComprasProduto
        public virtual Produto Produto { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("CarrinhoCompras")]
        public int IDCarrinhoFK { get; set; }

        [ForeignKey("Produto")]
        public int IDProdutoFK { get; set; }
    }
}