namespace AccessModifiers
{
    public class MyClass
    {
        #region Constructor
        // Konstruktor default tanpa parameter
        public MyClass()
        {

        }
        #endregion

        #region Method
        // method public dapat di akses di luar kelas
        public void Function1()
        {
            Console.WriteLine("This is function1");
            SomeValue += 1;
        }

        // method protected (dilindungi) dapat di akes kelas turunan(subkelas)
        protected void Function2()
        {
            Console.WriteLine("This is function2");
            SomeValue -= 1;
        }
        #endregion

        #region Property
        // property member kelas
        private int SomeValue = 1;

        // memanggil property kelas private dan mengatur value
        public int Data
        {
            get { return SomeValue; }
            set { SomeValue = value; }
        }
        #endregion
    }

    // kelas turunan dari kelas MyClass
    public class ChildClass : MyClass
    {
        // Konstruktor default tanpa parameter untuk ChildClass
        public ChildClass()
        {

        }

        // method public dapat di akses di luar kelas
        public void Function3()
        {
            Console.WriteLine("This is function3");
            // Memanggil method Function2 dari kelas dasar (MyClass)
            base.Function2();
        }

        // method public dapat di akses di luar kelas
        public void Function4()
        {
            Console.WriteLine("This is function4");
        }
    }
}