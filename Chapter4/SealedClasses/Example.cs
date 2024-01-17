namespace SealedClasses
{
    public class A
    {
        /// <summary>
        /// sealed digunakan dalam C# untuk mengonfirmasi bahwa suatu kelas atau metode 
        /// tidak dapat diwariskan atau di-override
        /// </summary>
        public A()
        {
            Console.WriteLine("A");
        }

        public virtual void Func1()
        {
            Console.WriteLine($"Func1 in class A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public override void Func1()
        {
            Console.WriteLine("Func1 in class B");
        }
    }

    // Example 2: Sealing an individual member
    public class C
    {
        public C() { }

        public virtual void Func2() { }
    }

    public class D : C
    {
        public D() { }

        public override void Func2() { }
    }

    public class E : D
    {
        public E() { }

        public override void Func2() { }
    }
}