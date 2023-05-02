string word = "race car";
//turns race car into racecar
var wordArray = word.ToCharArray();
List<char> wordArrayNoSpaces = new List<char>();
string oldWord = "";
string newword = "";
foreach (char c in wordArray)
{
    if (c == ' ') { continue; };
    wordArrayNoSpaces.Add(c);
    oldWord += c;
}
for (int i = wordArrayNoSpaces.Count - 1; i >= 0; i--)
{
    newword += wordArrayNoSpaces[i];
}
Console.WriteLine(oldWord == newword);