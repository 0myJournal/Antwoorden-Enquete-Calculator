

Dictionary<string, int> merken = new Dictionary<string, int>();


merken["lenovo"] = 0;
merken["hp"]=0;
merken["acer"]=0;
merken["dell"]=0;
merken["apple"]=0;
merken["msi"] = 0;
merken["overig"] = 0;
merken["asus"] = 0;


// Read the file and display it line by line.  
foreach (string antwoord in System.IO.File.ReadLines(@"C:\Users\Gebruiker\source\repos\C# lessen\antwoorden\antwoorden\antwoorden.txt"))
{
   
    if(CaseInsensitive(antwoord, "lenovo"))
    {
        merken["lenovo"]++;
        continue;
    }

    if (CaseInsensitive(antwoord, "hp"))
    {
        merken["hp"]++;
        continue;
    }

    if (CaseInsensitive(antwoord, "acer"))
    {
        merken["acer"]++;
        continue;
    }

    if (CaseInsensitive(antwoord, "dell"))
    {
        merken["dell"]++;
        continue ;
    }

    if (CaseInsensitive(antwoord, "apple"))
    {
        merken["apple"]++;
        continue;
    }

    if (CaseInsensitive(antwoord, "msi"))
    {
        merken["msi"]++;
        continue;
    }

    if (CaseInsensitive(antwoord, "asus"))
    {
        merken["asus"]++;
        continue;
    }


    merken["overig"]++;

}

bool CaseInsensitive(string antwoord, string checkString)
{
    if (merken[checkString] != null)
    {

    }
    else
    {
        merken[checkString] = 0;
    }

    return antwoord.IndexOf(checkString, StringComparison.OrdinalIgnoreCase) >= 0;
}

foreach(KeyValuePair<string, int> pair in merken)
{
    Console.WriteLine($"{pair.Key} heeft {pair.Value} antwoorden");
}


//berekenen van totale geld
int publicTotal = 0;
foreach (string geld in System.IO.File.ReadLines(@"C:\Users\Gebruiker\source\repos\C# lessen\antwoorden\antwoorden\geld.txt"))
{

    int numberOne = getNumber(0,geld);
    int numberTwo = getNumber(1,geld);

    if(numberOne != numberTwo)
    {
        int total = numberOne + numberTwo;
        publicTotal += total / 2;
    }
    else
    {
        publicTotal += numberOne;
    }
    

}

int getNumber(int index, string geld)
{
    if (geld.Contains('-'))
    {
        string[] strings = geld.Split('-');

        return Int32.Parse(strings[index]);
    }
    return 2000;
}

Console.WriteLine(publicTotal/194);
// Suspend the screen.  
System.Console.ReadLine();

