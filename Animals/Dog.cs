namespace Animals
{
    public class Dog: Animal
    {
        public string FavoriteToy { get; }
        public Dog(string name, string toy): base(name)
        {                                       // base(name) invokes the parent class constructor 
            this.FavoriteToy = toy;
        }
    }

}