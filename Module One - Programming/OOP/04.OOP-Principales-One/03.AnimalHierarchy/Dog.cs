namespace _03.AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        const string defaultSound = "I AM A DOG! Wolf, wolf. Scary.";
        public Dog(int age, string name, Gender sex)
            :base (age, name, sex, defaultSound)
        {
        }
        public Dog(int age, string name, Gender sex, string sound)
            : base(age, name, sex, sound)
        {
        }
    }
}
