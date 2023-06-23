using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Problem
{
    public class FindCategory
    {
        public string CategoryCheck(int age)
        {
            try
            {
                if (age >= 1 && age <= 14)
                {
                    return "Children";
                }
                else if (age >= 15 && age <= 24)
                {
                    return "Youth";
                }
                else if (age >= 25 && age <= 64)
                {
                    return "Adults";
                }
                else
                {
                    return "Seniors";
                }
            }
            catch(Exception)
            {
                throw new PersonAgeException(PersonAgeException.Exceptiontype.NULL, "Age is Null");
            }
            catch (Exception)
            {
                throw new PersonAgeException(PersonAgeException.Exceptiontype.EMPTY, "Age is Empty");
            }

        }
    }
}
