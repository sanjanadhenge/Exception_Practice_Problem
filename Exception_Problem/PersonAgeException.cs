using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Problem
{
    internal class PersonAgeException : Exception
    {
        public enum Exceptiontype
        {
            NULL,EMPTY
        }
        public Exceptiontype Type { get; set; }
        public PersonAgeException(Exceptiontype Type , string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
