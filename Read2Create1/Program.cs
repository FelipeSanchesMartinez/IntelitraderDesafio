
Console.WriteLine("Passe o local do primeiro arquivo:");
string? filePath1 = Console.ReadLine();
Console.WriteLine("Passe o local do segundo arquivo:");
string? filePath2 = Console.ReadLine();
Console.WriteLine("Passe o local que deseja salvar o arquivo");
string? pathSave = Console.ReadLine();

try
{
    StreamReader reader1 = new StreamReader(filePath1);
    string content1 = reader1.ReadToEnd();
    reader1.Close();

    StreamReader reader2 = new StreamReader(filePath2);
    string content2 = reader2.ReadToEnd();
    reader2.Close();

    string contentNew = $"{content1}\n\n{content2}";

    StreamWriter sw = new StreamWriter($"{pathSave}\\terceiroArquivo.txt");

    sw.WriteLine(contentNew);
    sw.Close();
    Console.WriteLine($"Terceiro arquivo criado com sucesso, local {pathSave}\\terceiroArquivo.txt");


}
catch (Exception error)
{
    Console.WriteLine($"Error {error.Message}");
}


