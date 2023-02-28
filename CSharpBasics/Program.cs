// 10 min
// 
//   Die Klasse Sample soll die beiden Funktionen Alloc und Free verwenden um 
//   nativen Speicher anzufordern und wieder freizugeben. Die Implementierung von Alloc und Free
//   ist hierbei nicht entscheidend.
// 
// Aufgabe: 
//   Schreibe die Klasse Sample so um, dass diese 
//
//   a) Im Konstruktur Alloc aufruft 
//   b) Das Dispose Pattern verwendet um mit dem einmaligen Aufruf der Funktion Free die Ressourcen wieder
//      freizugeben
//   c) Sicherzustellen, dass der GC den Speicher auch freigibt, wenn kein Dispose aufgerufen worden ist

//
// The Sample class shall use the Alloc and Free functions to // request and release native memory. 
// request and release native memory. The implementation of Alloc and Free
// is not critical for this purpose.
// 
// Task: 
//   Rewrite the Sample class in such a way that this 
//
//   a) Call Alloc in the constructor
//   b) Use the Dispose pattern to release the resources with a single call to the Free function.
//   c) Ensure that the GC releases the memory even if no Dispose has been called.



var mySample = new Sample();


class Sample
{ 
    private void Alloc() { Console.WriteLine("Alloc"); }
    private void Free() { Console.WriteLine("Free"); }
}