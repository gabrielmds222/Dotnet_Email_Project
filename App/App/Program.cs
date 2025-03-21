using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "../Doadores.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("❌ Arquivo CSV não encontrado!");
            return;
        }

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";" // Define o delimitador como ponto e vírgula (;)
        };

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, config))
        {
            var registros = csv.GetRecords<Dado>();

            Console.WriteLine("📄 Conteúdo do CSV:");
            foreach (var dado in registros)
            {
                Console.WriteLine($"Nome: {dado.Nome}, Email: {dado.Email}");
            }
        }
    }
}

// Classe que representa a estrutura do CSV
public class Dado
{
    public string Nome { get; set; }
    public string Email { get; set; }
}