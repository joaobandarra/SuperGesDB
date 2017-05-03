using System.Data.Entity;

namespace ProjetoFinalSuperGes.Models
{
    public class SuperGesDB : DbContext
    {


        //**********************************************************
        //  informar a entity framework que as classes abaixo 
        //  descritas devem ser associadas a uma base de dados
        //**********************************************************
        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Encomenda> Encomenda { get; set; }

        public virtual DbSet<CarrinhoCompras> CarrinhoCompras { get; set; }

        public virtual DbSet<CarrinhoComprasProduto> CarrinhoComprasProduto { get; set; }

        public virtual DbSet<Produto> Produto { get; set; }

        public virtual DbSet<EncomendaProduto> EncomendaProduto { get; set; }

        public virtual DbSet<Imagens> Imagens { get; set; }

        public virtual DbSet<TiposEnvio> TiposEnvio { get; set; }

        public virtual DbSet<RegiaoEnvio> RegiaoEnvio { get; set; }
        //**********************************************************
        //  onde criar e de que tipo será a base de dados
        //**********************************************************
        public SuperGesDB() : base("localizacaoDaBD")
        {

        }
    }
}