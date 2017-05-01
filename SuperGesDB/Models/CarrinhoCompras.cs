using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class CarrinhoCompras
    {
        public CarrinhoCompras()
        {
            ListaCarrinhoComprasProduto = new HashSet<CarrinhoComprasProduto>();
        }

        [Key]
        public int IDCarrinho { get; set; }

        [Required]
        public int Quantidade { get; set; }

        // relaciona o objeto Cliente com um objeto CarrinhoCompras
        public virtual Cliente Cliente { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Cliente")]
        public int IDClienteFK { get; set; }


        // especificar que um carrinho de compras tem muitos Carrinhos de compras/produto
        public ICollection<CarrinhoComprasProduto> ListaCarrinhoComprasProduto { get; set; }
    }
}