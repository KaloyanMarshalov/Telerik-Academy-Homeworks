﻿namespace _02.StudentsAndWorkers
{
    public abstract class Human
    {
        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
