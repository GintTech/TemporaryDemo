using Backend.DAL;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel; //for [DataObject]
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BLL
{
    [DataObject]
    public class StudentController // controls access
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Student> ListAllStudents()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
