interface ISpellChecker
{
    void Display();
    void Insert(string x);
    bool Search(string x);
    string GenerateAlternatives(string x);
}