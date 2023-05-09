

using C05EX_textManager;

while (true) 
{
    //     Król Karol kupił królowej Karolinie korale koloru koralowego
    Console.WriteLine("PLEASE PROVIDE YOUR SENTENCE TO SEARCH FOR LONGEST WORD");
    string sentence = Console.ReadLine();

    var TextManager = new TextManager();
    List<string> longestWords = TextManager.FindLongesWords(sentence);

    Console.WriteLine("Longest word(s) found in your sentence:");
    Console.WriteLine(string.Join(" , ", longestWords));

}