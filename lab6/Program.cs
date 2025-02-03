using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Task1
{
    public static void SaveAlbumNumber(string fileName, string albumNumber)
    {
        File.WriteAllText(fileName, albumNumber);
    }
}

class Task2
{
    public static string ReadFileContent(string fileName)
    {
        return File.Exists(fileName) ? File.ReadAllText(fileName) : "Plik nie istnieje";
    }
}

class Task3
{
    public static int CountFemalePesels(string fileName)
    {
        if (!File.Exists(fileName)) return 0;
        var pesels = File.ReadAllLines(fileName);
        return pesels.Count(p => p.Length == 11 && (p[9] % 2 == 0));
    }
}

class PopulationData
{
    public Indicator indicator { get; set; }
    public Country country { get; set; }
    public long? value { get; set; }
    public int date { get; set; }
}

class Indicator { public string id { get; set; } public string value { get; set; } }
class Country { public string id { get; set; } public string value { get; set; } }

class Task4
{
    private List<PopulationData> _data;

    public Task4(string jsonFile)
    {
        _data = JsonConvert.DeserializeObject<List<PopulationData>>(File.ReadAllText(jsonFile));
    }

    public long? GetPopulationDifference(string country, int year1, int year2)
    {
        var pop1 = _data.FirstOrDefault(p => p.country.value == country && p.date == year1)?.value;
        var pop2 = _data.FirstOrDefault(p => p.country.value == country && p.date == year2)?.value;
        return pop1.HasValue && pop2.HasValue ? pop2 - pop1 : (long?)null;
    }

    public void DisplayPopulation(string country, int year)
    {
        var pop = _data.FirstOrDefault(p => p.country.value == country && p.date == year)?.value;
        Console.WriteLine(pop.HasValue ? $"Populacja {country} w {year}: {pop}" : "Brak danych");
    }

    public double? GetPopulationGrowthPercentage(string country, int year)
    {
        var popCurrent = _data.FirstOrDefault(p => p.country.value == country && p.date == year)?.value;
        var popPrevious = _data.FirstOrDefault(p => p.country.value == country && p.date == year - 1)?.value;
        return popCurrent.HasValue && popPrevious.HasValue ? ((double)(popCurrent - popPrevious) / popPrevious) * 100 : (double?)null;
    }
}

interface IPersonRepository
{
    void AddPerson(string person);
    List<string> GetAllPersons();
}

class FilePersonRepository : IPersonRepository
{
    private readonly string _filePath;

    public FilePersonRepository(string filePath)
    {
        _filePath = filePath;
        if (!File.Exists(_filePath)) File.Create(_filePath).Dispose();
    }

    public void AddPerson(string person)
    {
        File.AppendAllText(_filePath, person + "\n");
    }

    public List<string> GetAllPersons()
    {
        return File.Exists(_filePath) ? File.ReadAllLines(_filePath).ToList() : new List<string>();
    }
}