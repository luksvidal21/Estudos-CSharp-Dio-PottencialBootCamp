try
{
    String[] arquivo = File.ReadAllLines("Arquivo/aquivo_texto.txt");
}
catch(FileNotFoundException ex)
{
    //Excessão genérica é capturada com a classe Exception
    Console.WriteLine($" O arquivo não foi encontrado e a excessão lançada foi: {ex}");
}
catch(DirectoryNotFoundException diretorioErrado)
{
    Console.WriteLine($" O diretório não foi encontrado e a excessão lançada foi: {diretorioErrado}");
}
finally
{
    Console.WriteLine("O programa teve as excessões tratadas");
}