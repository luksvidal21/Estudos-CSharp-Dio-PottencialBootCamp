using Tuple.Fundamentos.Models;

//Primeira forma de declarar uma tupla:
//(int,string,string,decimal) tupla = (1,"Lucas","Vidal",1.80M);
//Variação da primeira forma de declarar uma tupla:

//MELHOR FORMA DE DECLARAR UMA TUPLA
//(int Id, string Nome, string SobreNome , decimal Altura) tupla1variacao = (1,"Lucas","Vidal",1.80M);
//A maior vantagem dessa variação da primeira forma de declarar é que consigo nomear cada um dos atributos em que declaro um tipo

//Segunda forma de declarar uma tupla:
//ValueTuple<int,string,string,decimal> tupla2 = (1,"Lucas","Vidal",1.80M);


//Terceira forma de declarar uma tupla:

//var tupla3 = Tuple.Create(1,"Lucas","Vidal",1.80M);


LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivos/Arquivo_Texto.txt");
//Caso precise descartar uma das propriedades é possível utilizar o "_"

if(sucesso){
    //Console.WriteLine($"A quantidade de linha é : {quantidadeDeLinhas}");
    foreach(string linha in linhas){
        Console.WriteLine(linha);
    }
}
else 
{
    Console.WriteLine("Não foi possível executar o arquivo");
}

