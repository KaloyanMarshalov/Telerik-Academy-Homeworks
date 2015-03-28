namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class SchoolClass : ICommentable
    {
        private string uniqueTextIdentifier;
        public SchoolClass(string UniqueTextIdentifier, List<Teacher> teachers)
        {
            this.UniquieTextIdentifier = uniqueTextIdentifier;
            this.Teachers = teachers;
        }
        public string UniquieTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
            private set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Uniquie Text Identifier cannot be less than 10 symbols long!");
                }
                this.uniqueTextIdentifier = value;
            }
        }
        public List<Teacher> Teachers { get; private set; }
        public List<string> Comments { get; set; }

        public void MakeComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
