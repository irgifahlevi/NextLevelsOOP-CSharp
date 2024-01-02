namespace ObjectInitializers
{
    public class Pet
    {
        #region Property
        public string Name { get; set; } = "";
        public int Age { get; set; } = 1;
        #endregion

        #region Constructor
        public Pet()
        {

        }
        #endregion
    }

    // kelas turunan dari kelas Pet
    public class Dog : Pet
    {
        #region Property
        public bool IsTrained { get; set; } = false;
        #endregion

        #region Constructor
        public Dog()
        {

        }
        #endregion
    }

    // kelas turunan dari kelas Pet
    public class Cat : Pet
    {
        #region Property
        public bool IsDeclawed { get; set; } = false;
        #endregion

        #region Constructor
        public Cat()
        {

        }
        #endregion
    }

    public class Owner
    {
        public string OwnerName { get; set; } = "";
        public string Address { get; set; } = "";
        public List<Pet>? Pets { get; set; }
    }
}