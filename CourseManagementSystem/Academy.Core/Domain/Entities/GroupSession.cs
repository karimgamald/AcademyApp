using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class GroupSession
    {
        public int GroupId { get; set; }    
        public Group? group { get; set; }

        public int SessionId { get; set; }
        public Session? session { get; set; }
    }
}
