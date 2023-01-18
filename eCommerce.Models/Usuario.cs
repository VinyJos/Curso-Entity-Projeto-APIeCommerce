using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; }
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }
        public string? SituacaoCadastro { get; set; }
        public DateTimeOffset DataCadastro { get; set; } 

        public Contato? Contato { get; set; }
        // lisa 
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; } // ICollection - é um conjunto de objetos, assim como a lista, enum
        // Usuário pode ter vários departamentos
        public ICollection<Departamento>? Departamentos { get; set; }

    }
}   
