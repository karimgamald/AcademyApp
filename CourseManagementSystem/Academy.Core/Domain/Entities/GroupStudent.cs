using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class GroupStudent
    {
        public int GroupId { get; set; }
        public Group? group { get; set; }

        public int StudentId { get; set; }
        public Student? student { get; set; }    
    }
}
