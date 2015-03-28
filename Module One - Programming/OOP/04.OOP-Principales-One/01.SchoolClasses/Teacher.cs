namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;


    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;
        private List<string> comments;
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }
        public List<Discipline> Disciplines 
        { 
            get
            {
                return this.disciplines;
            }
            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("Cannot have less than 1 discipline in a teacher!");
                }
                this.disciplines = value;
            }
        }
        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                if (value.Count < 0)
                {
                    throw new ArgumentException("Cannot add zero comments list!");
                }
            }
        }

        public void MakeComment(string comment)
        {
            if (comment.Length < 10)
            {
                throw new ArgumentException("Cannot add a comment shorter than 10 symbols!");
            }
            this.Comments.Add(comment);
        }
        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }
    }
}
