using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nuget.Fundamentos.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id =  id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;

        }
        
        public int Id { get; set; }
        [JsonProperty("nome_Produto")] //Quando a key do Json for diferente das convenções de escritas de classe do C# utilizamos essa propriedade para colocar o nome correto
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}