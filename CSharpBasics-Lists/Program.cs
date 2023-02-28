// 10 min
//
// Der nachfolgende Code soll alle Elemente in der Liste entfernen die 
// ein Zeichen "-" enthalten. 
// 
// Aufgabe: 
// 
// a) Der Code enthält einen Fehler, welchen?
// b) Korrigiere den Code, so dass dieser ohne Fehler durchläuft und die Liste nachher
//    keine Elemente mit "-" Zeichen mehr enthält 
//
//
// The following code is to remove all elements in the list that 
// contain a "-" character. 
// 
// Task: 
// 
// a) The code contains an error, which one?
// b) Correct the code so that it runs without errors and the list afterwards contains no elements
//    with "-" characters anymore 



string[] elements = { "one", "two", "-", "three", "--" };


List <string> numbers = new List<string>(elements);


foreach (string element in numbers)
{
    if (element.Contains("-"))
    {
        numbers.Remove(element);
    }
}

Console.WriteLine(String.Join(", ", numbers));