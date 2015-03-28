namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Student : Person, ICommentable
    {
        private int uniqueClassNumber;
        private List<string> comments;

        public Student(string name, int uniqueClassNumber) 
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            this.Comments = new List<string>();
        }
        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            private set { this.uniqueClassNumber = value; }
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
    }
}
