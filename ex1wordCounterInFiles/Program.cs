Console.WriteLine("elo");

var folder = @".\Test";
var txtFiles = Directory.GetFiles(folder, "*.txt");




foreach (var txtFile in txtFiles)
{
    var readFile = File.ReadAllText(txtFile);
    var str = readFile.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    System.Console.WriteLine($"Number of words in {txtFile}: " + str.Length);
}


    Console.ReadLine();
