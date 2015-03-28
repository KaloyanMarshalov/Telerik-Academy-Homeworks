namespace _03.AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        const Gender defaultSex = Gender.Male;

        public Tomcat(int age, string name)
            : base(age, name, defaultSex)
        {
        }
        public Tomcat(int age, string name, string sound)
            : base(age, name, defaultSex, sound)
        {
        }
    }
}
