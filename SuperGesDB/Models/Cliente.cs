using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class Cliente
    {
        // vai representar os dados da tabela dos Clientes

        // criar o construtor desta classe
        // e carregar a lista de Carrinhos de compras
        public Cliente()
        {
            ListaCarrinhoCompras = new HashSet<CarrinhoCompras>();
            ListaEncomendas = new HashSet<Encomenda>();
        }

        [Key]
        public int IDCliente { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(255)]
        public string Morada { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string InfoCartaoCredito { get; set; }

        [Required]
        [StringLength(9)]
        public string NIF { get; set; }

        // especificar que um cliente tem muitos Carrinhos de compras
        public ICollection<CarrinhoCompras> ListaCarrinhoCompras { get; set; }
        // especificar que um cliente faz muitas encomendas
        public ICollection<Encomenda> ListaEncomendas { get; set; }
    }
}