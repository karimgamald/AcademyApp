using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Attendance
    {
        public int AttendanceId {  get; set; }
        public int? SessionId { get; set; }
        public Session? session { get; set; }

        public int? StudentId { get; set; }
        public Student? student { get; set; }

        public string Status { get; set; } = "present"; // present / absent / late
        public string? Note { get; set; }

    }
}
