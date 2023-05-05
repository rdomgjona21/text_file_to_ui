using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class UserDisplayer
    {
        public string Name(User reader)
        {
            string FullName = reader.FirstName + " " + reader.LastName;
            return FullName;
        }
    }
}
