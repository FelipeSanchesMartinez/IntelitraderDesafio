

Console.WriteLine("Aperte C para codificar um arquivo, D para decodificar:");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();

if (key.KeyChar.ToString().ToUpper() == "C")
{


    Console.WriteLine("Informe o local do arquivo:");
    string file = Console.ReadLine();
    try
    {
        StreamReader reader = new StreamReader(file);
        string content = reader.ReadToEnd();
        reader.Close();


        byte[] fileBytes = File.ReadAllBytes(file);
        string base64EncodedString = Convert.ToBase64String(fileBytes);

        Console.WriteLine("Arquivo codificado em Base64:");
        Console.WriteLine(base64EncodedString);
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error {error.Message}");
    }
}

else if (key.KeyChar.ToString().ToUpper() == "D")
{
    Console.WriteLine("Informe o valor codificado:");
    string encodedText = Console.ReadLine();
    try
    {
        byte[] decodedBytes = Convert.FromBase64String(encodedText);
        string decodedString = System.Text.Encoding.UTF8.GetString(decodedBytes);

        Console.WriteLine("Conteúdo decodificado:");
        Console.WriteLine(decodedString);
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error {error.Message}");
    }


}
else
{
    Console.WriteLine("Tecla invalida finalizando ....");
}

