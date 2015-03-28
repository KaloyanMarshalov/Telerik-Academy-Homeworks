namespace _03.AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        const Gender defaultSex = Gender.Female;

        public Kitten(int age, string name)
            : base(age, name, defaultSex)
        {
        }
        public Kitten(int age, string name, string sound)
            : base(age, name, defaultSex, sound)
        {
        }
    }
}
