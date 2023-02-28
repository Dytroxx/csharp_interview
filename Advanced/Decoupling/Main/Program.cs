// 
// Die Library Module1 hat eine direkte Abhängigkeit von Module2
// 
// Diese Abhängigkeit soll folgendermaßen aufgelöst werden:
// 
//   1) Module1 darf nicht mehr abhängig sein von Module2
//   2) Beide Libraries, Module1 und Module2 dürfen keine weiteren Abhängigkeiten haben, außer dem .NET Framework
//   3) Der Aufruf m1.Foo() soll die gleiche Funktionalität haben und die Methode m2.Foo() aufrufen 
//      sodass die Aufrufe/Ablauf und Ausgaben in der Console gleich bleiben
//


using Module1;
using Module2;

M2 m2 = new M2();
M1 m1 = new M1(m2);

m1.Foo();