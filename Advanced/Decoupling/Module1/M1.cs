using Module2;

namespace Module1
{
    public class M1
    {
        private readonly M2 _m;

        public M1(M2 m)
        {
            _m = m;
        }

        public void Foo()
        {
            Console.WriteLine("Called M1.Foo");
            _m.Foo();
        }
    }
}