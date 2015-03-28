namespace _03.AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public Animal(int age, string name, Gender sex, string sound)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
            this.Sound = sound;
        }
        public int Age { get; private set; }
        public string Name { get; set; }
        public Gender Sex { get; private set; }

        public string Sound { get; set; }

        public string ProduceSound()
        {
            return this.Sound;
        }
    }
}
