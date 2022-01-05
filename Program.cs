using System.IO;
using System.Collections.Generic;



var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory  = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory );
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");

Directory.CreateDirectory(salesTotalDir);
File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);


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
