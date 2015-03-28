namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        List<string> Comments { get; set; }
        void MakeComment(string comment);
    }
}
