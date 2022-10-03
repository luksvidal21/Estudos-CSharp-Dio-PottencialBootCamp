using System;
using System.Collections.Generic;
using System.Linq;
using Nuget.Fundamentos.Models;
using Newtonsoft.Json;

//Utilizando pacote Nuget para serializar valores de uma classe C# para Json

DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1,"Computador",2200.50M,dataAtual);
Venda v2 = new Venda(2,"Cooler",150.79M,dataAtual);

List<Venda> listaDeVendas = new List<Venda>();

listaDeVendas.Add(v1);
listaDeVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

string conteudoDoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaDeVendasJson = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);

foreach(Venda venda in listaDeVendasJson){
    Console.WriteLine($"Venda : \n Id - {venda.Id}\n Produto - {venda.Produto}\n Preço - {venda.Preco} \n Data - {venda.DataVenda.ToString("dd/MM/yyyy hh:mm")}");
}

