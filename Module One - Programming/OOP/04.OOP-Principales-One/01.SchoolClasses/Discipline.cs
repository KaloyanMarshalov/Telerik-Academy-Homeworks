namespace _01.SchoolClasses
{
    using System;
    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcersises = numberOfExercises;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Name of Discipline cannot be less than 10");
                }
                this.Name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExcersises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.numberOfExercises = value;
            }
        }
        public System.Collections.Generic.List<string> Comments
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public void MakeComment(string comment)
        {
            throw new System.NotImplementedException();
        }
    }
}
