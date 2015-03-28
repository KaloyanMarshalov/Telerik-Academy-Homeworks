namespace _03.AnimalHierarchy
{
    public abstract class Cat : Animal, ISound
    {
        const string defaultSound = "I AM A Cat! Meow, meow. Pet me, or i will scratch the fourniture!";
        public Cat(int age, string name, Gender sex)
            :base (age, name, sex, defaultSound)
        {
        }
        public Cat(int age, string name, Gender sex, string sound)
            : base(age, name, sex, sound)
        {
        }
    }
}
