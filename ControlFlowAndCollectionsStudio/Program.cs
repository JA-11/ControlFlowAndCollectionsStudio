Console.WriteLine("Please enter a sentence:");
string userInput = Console.ReadLine();
string sentence = userInput.ToLower();

Dictionary<char, int> CharacterCount = new Dictionary<char, int>();

foreach (char letter in sentence)
{
    if (!CharacterCount.ContainsKey(letter))
    {
        CharacterCount.Add(letter, 1);
    }
    else
    {
        CharacterCount[letter] = CharacterCount[letter] + 1;
    }
}

foreach (char letter in CharacterCount.Keys)
{
    Console.WriteLine($"{letter}: {CharacterCount[letter]}");
}