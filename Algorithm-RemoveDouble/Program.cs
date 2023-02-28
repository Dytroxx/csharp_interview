// 15 min
//
// The [elements] list contains duplicate elements. These
// should be removed without changing the order of the elements.
// Fill the RemoveDoubles function with code so that it returns a list
// where all duplicate elements are removed and the original entries are
// in the same order as a new list.
//
// The [elements] list contains duplicate elements. These
// shall be removed without changing the order of the elements.
// Fill the RemoveDoubles function with code so that it returns a list
// where all duplicate elements are removed and the original entries are
// in the same order as a new list.


string[] elements = { "1", "2", "3", "1", "5", "8", "7", "4", "3", "3", "2", "1", "2", "3" };
List<string> numbers = new List<string>(elements);

List<string> allDoublesRemoved = RemoveDoubles(numbers);

Console.WriteLine(String.Join(", ", allDoublesRemoved));

List<string> RemoveDoubles(List<string> elements)
{
    return elements;
}

