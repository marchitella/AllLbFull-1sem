using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4
{
    public class Owner
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public Owner(int id, string name, string organization)
        {
            this.ID = id;
            this.Name = name;
            this.Organization = organization;
        }
    }
}
