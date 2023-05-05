using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public class UserParser
    {
        public User Parse(Reader reader)
        {

            UserFileReader userFileReader = new UserFileReader();
            User user = new User();
            reader = userFileReader.FileOpen();
            user.FirstName = reader.FirstNameString.Substring(4);
            user.LastName = reader.LastNameString.Substring(8);
            user.YearOfBirth = reader.YearOfBirthString.Substring(15);
            user.City = reader.CityString.Substring(13);
            user.Faculty = reader.FacultyString.Substring(9);
            user.Role = reader.RoleString.Substring(6);
            if (user.Role == "student")
            {
                user.FavoriteCourse = reader.FavoriteCourseString.Substring(17);
            }
            else
            {
                user.Department = reader.DepartmentString.Substring(8);
            }
            
            return user;
        }
    }

}
