using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public class UserFileReader
    {
       
        public Reader FileOpen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files only(*.txt)|*.txt";
            dialog.Multiselect = false;
            Reader reader = new Reader();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader streamreader = new StreamReader(dialog.FileName))
                {
                    string[] lines = streamreader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        if (line.Contains("Ime"))
                        {
                            reader.FirstNameString = line;
                        }
                        if (line.Contains("Prezime"))
                        {
                            reader.LastNameString = line;
                        }
                        if (line.Contains("Godina"))
                        {
                            reader.YearOfBirthString = line;
                        }
                        if (line.Contains("Grad"))
                        {
                            reader.CityString = line;
                        }
                        if (line.Contains("Fakultet"))
                        {
                            reader.FacultyString = line;
                        }
                        if (line.Contains("Uloga"))
                        {
                            reader.RoleString = line;
                        }
                        if (line.Contains("Najdraži kolegij"))
                        {
                            reader.FavoriteCourseString = line;
                        }
                        if (line.Contains("Katedra"))
                        {
                            reader.DepartmentString = line;
                        }
                        if (line.Contains("Datoteci pristupljeno puta"))
                        {
                            reader.Access = line;

                        }
                    }
                }
            }
            return reader;
        }
    }
}
