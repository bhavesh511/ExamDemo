using ExamDemo.Framework.Infrastructure;
using System;


namespace ExamDemo.Database.Models
{
    public class ExamResult : BaseEntity
    {
        public Guid UniqueName { get; set; }
        public string ExamName { get; set; }
        public bool IsActive { get; set; }
        public int PassMark { get; set; }
        public int TotalMark { get; set; }
        public int totalQuestions { get; set; }
    }
}
