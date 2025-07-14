using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PasswordHash {  get; set; } = string.Empty;
        public string Faculty {  get; set; } = string.Empty;
        public bool IsGraduated { get; set; } = false;
        public DateOnly BirthDate {  get; set; }

        public int? GroupId { get; set; }
        public Group? group { get; set; }

        public ICollection<Attendance> Attendances { get; set; } = new HashSet<Attendance>();

        public ICollection<Solution> Solutions { get; set; } = new List<Solution>();

        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();

        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
    }
}
