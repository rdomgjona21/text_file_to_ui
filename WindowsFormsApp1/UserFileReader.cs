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
        string Txt;
        public string FileOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text documents|*.txt";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader str = new StreamReader(ofd.SafeFileName)) 
                { 
                    Txt = str.ReadToEnd();
                    return Txt;
                }
            }
            return Txt;
        }
    }
}
