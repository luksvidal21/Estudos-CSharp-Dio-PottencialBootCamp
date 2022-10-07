using TiposEspeciais.Fundamentos.Models;

bool? desejaReceberEmail = true;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value){
    Console.WriteLine("Deseja receber email");
}

else{
    Console.WriteLine("Não escolheu ou não deseja receber email");
}

//Instanciando Método Genérico 

MeuArray<int> numero = new MeuArray<int>();

MeuArray<string> texto = new MeuArray<string>();

numero.AdicionarElemento(10);

texto.AdicionarElemento("Lorem ipsum");

Console.WriteLine(numero[0]);
Console.WriteLine(texto[0]);


