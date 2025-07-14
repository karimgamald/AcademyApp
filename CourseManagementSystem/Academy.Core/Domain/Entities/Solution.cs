using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Domain.Entities
{
    public class Solution
    {
        public int SolutionId { get; set; }

        public int? TaskId { get; set; }
        public Task? task { get; set; }

        public int? StudentId { get; set; }
        public Student? student { get; set; }

        public DateTime SubmittedAt { get;set; }
        public string FileUrl { get; set; } = string.Empty;
        public double Grade { get; set; }

        
    }
}
