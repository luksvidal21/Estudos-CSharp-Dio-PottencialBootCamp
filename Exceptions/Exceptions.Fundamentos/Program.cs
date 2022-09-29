try
{
    
    String[] arquivo = File.ReadAllLines("Arquivos/Arquivo_Texto.txt");

    foreach(string linhas in arquivo){
        Console.WriteLine(linhas);
    }
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
}