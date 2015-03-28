namespace _01.SchoolClasses
{
    using System.Collections.Generic;
    class School
    {
        public School(string name, List<SchoolClass> classes)
        {
            this.Name = name;
            this.Classes = classes;
        }
        public string Name { get; set; }
        public List<SchoolClass> Classes { get; set; }
    }
}
