namespace _03.AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        const string defaultSound = "I AM A Frog! #iJumped #IAteAFly.";
        public Frog(int age, string name, Gender sex)
            :base (age, name, sex, defaultSound)
        {
        }
        public Frog(int age, string name, Gender sex, string sound)
            : base(age, name, sex, sound)
        {
        }
    }
}
