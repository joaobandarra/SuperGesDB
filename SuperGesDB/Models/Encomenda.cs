using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalSuperGes.Models
{
    public class Encomenda
    {
        // vai representar os dados da tabela das Encomendas

        // criar o construtor desta classe
        // e carregar a lista de encomendas/produto   
        public Encomenda()
        {
            ListaEncomendaProduto = new HashSet<EncomendaProduto>();

        }

        [Key]
        public int IDEncomenda { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataCriacaoEncomenda { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataEnvioEncomenda { get; set; }

        [Required]
        [StringLength(10)]
        public string EstadoCompra { get; set; }

        [Required]
        public double CustoEnvio { get; set; }

        [Required]
        [StringLength(255)]
        public string MoradaFaturacao { get; set; }

        [Required]
        [StringLength(20)]
        public string CodPostalFaturacao { get; set; }

        [Required]
        [StringLength(255)]
        public string MoradaEntrega { get; set; }

        [Required]
        [StringLength(20)]
        public string CodigoPostalEntrega { get; set; }

        // relaciona o objeto Cliente com um objeto Encomenda
        public virtual Cliente Cliente { get; set; }
        // relaciona o objeto TiposEnvio com um objeto Encomenda
        public virtual TiposEnvio TiposEnvio { get; set; }
        // relaciona o objeto RegiaoEnvio com um objeto Encomenda
        public virtual RegiaoEnvio RegiaoEnvio { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Cliente")]
        public int IDClienteFK { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("TiposEnvio")]
        public int IDFK { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("RegiaoEnvio")]
        public int IDRegiaoEnvioFK { get; set; }

        // especificar que um cliente tem muitos Carrinhos de compras
        public ICollection<EncomendaProduto> ListaEncomendaProduto { get; set; }
    }
}