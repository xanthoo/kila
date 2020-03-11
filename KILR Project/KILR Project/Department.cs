using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    class Department
    {
        private int id;
        private String name;
        private int maxStaff; 

        public int Id
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public int MaxStaff
        {
            get;
            set;
        }

        public Department(int id, String name, int maxStaff)
        {
            this.id = id;
            this.name = name;
            this.maxStaff = maxStaff;
        }

        public String GetInfo()
        {
            return $"Department id: {this.id} , name: {this.name} with a maximum staff capacity of {this.maxStaff}";
        }
    }
}
