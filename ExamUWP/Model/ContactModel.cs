using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamUWP.Entity;
using ExamUWP.Ultil;

namespace ExamUWP.Model
{
    class ContactModel
    {



        public bool Insert(Contact contact)
        {
            try
            {
                using (var stt = SQLUltil.GetIntances().Connection
                    .Prepare("INSERT INTO Contact (Name, NumberPhone) VALUES (?, ?)"))
                {
                    stt.Bind(1, contact.Name);
                    stt.Bind(2, contact.NumberPhone);
                    stt.Step();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
