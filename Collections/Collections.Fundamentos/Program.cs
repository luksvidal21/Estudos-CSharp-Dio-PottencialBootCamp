Queue<int> fila = new Queue<int>();


//Exemplos de Filas(Queues) no C#
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);
fila.Enqueue(12);

Console.WriteLine("Itens da Fila:");

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"O ITEM REMOVIDO DA FILA É : {fila.Dequeue()}");

Console.WriteLine("-----------------\n");



Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);
pilha.Push(12);

Console.WriteLine("Itens da Pilha:");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"O ITEM REMOVIDO DA PILHA É : {pilha.Pop()}");

Console.WriteLine($"\n-----------------------\n");



Dictionary<int,string> estados = new Dictionary<int, string>();

estados.Add(1,"Acre");
estados.Add(2,"Amazonas");

try
{
    estados.Add(1,"Acre");
}
catch
{
    Console.WriteLine("Você tentou adicionar um estado que já existe");
}
finally
{   Console.WriteLine($"O dados do Dicionário são:");
    foreach(var item in estados)
    {
        Console.WriteLine($"Chave : {item.Key} ; Valor : {item.Value} ");
    }
}
