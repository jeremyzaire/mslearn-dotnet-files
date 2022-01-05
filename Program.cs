using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;



var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory  = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory );
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");

var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

Directory.CreateDirectory(salesTotalDir);
File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), salesData.Total.ToString());


foreach(var file in salesFiles) {
    Console.WriteLine(file);
}


IEnumerable<String> FindFiles(String folderName) {
    List<String> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
    
    foreach(var file in foundFiles) {
        Console.WriteLine(file);
    }

    return salesFiles;
}

