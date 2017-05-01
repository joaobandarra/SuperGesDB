using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class Produto
    {
        public Produto()
        {
            ListaImagens = new HashSet<Imagens>();
            ListaCarrinhoComprasProduto = new HashSet<CarrinhoComprasProduto>();
            ListaEncomendaProduto = new HashSet<EncomendaProduto>();
        }

        [Key]
        public int IDProduto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(255)]
        public string Descricao { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        [StringLength(3)]
        public string IVA { get; set; }


        // especificar que um produto tem muitos Imagens
        public ICollection<Imagens> ListaImagens { get; set; }

        // especificar que um produto está em muitas encomendas
        public ICollection<EncomendaProduto> ListaEncomendaProduto { get; set; }

        // especificar que um produto está em muitos carrinhos de compras/produto
        public ICollection<CarrinhoComprasProduto> ListaCarrinhoComprasProduto { get; set; }

    }
}