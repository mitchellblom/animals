namespace Animals
{
    public class Animal
    {
        private string _species;    // this is a field. Not a property that external code can reach
        private double _walkingSpeed;
        public string Name { get; }
        public string Species {         // external code can only read
            get
            {
                return _species;
            }
        }
        public double WalkingSpeed {      
            get
            {
                return _walkingSpeed;
            }
        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public void SetSpecies(string species)          // internally can access 
        {
            _species = species;
        }

        public void Walk(double speed)
        {
            _walkingSpeed = speed;
        }

    }

}