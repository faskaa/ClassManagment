using ClassManagment.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment.Data.Models
{
    public class Student : BaseModel
    {
        private static int id = 0;

        public Student()
        {
            Id = id;
            id++;
        }

        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
    }
}
