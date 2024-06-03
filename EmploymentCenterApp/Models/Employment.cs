using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmploymentCenterApp.Models
{
    public class Employment
    {
        [Key]
        public uint Id { get; set; }

        public uint ApplicantId { get; set; }

        public Applicant Applicant { get; set; }

        public uint WorkId { get; set; }
        public Work Work { get; set; }

        public DateTime EmploymentDate { get; set; }
        public DateTime DismissalDate { get; set; }


        public Employment() {
            EmploymentDate = DateTime.Now;
            DismissalDate = DateTime.MinValue;
        }
        public Employment(uint id, uint applicantId, Applicant applicant, uint workId, Work work, DateTime employmentDate, DateTime dismissalDate)
        {
            Id = id;
            ApplicantId = applicantId;
            Applicant = applicant;
            WorkId = workId;
            Work = work;
            EmploymentDate = employmentDate;
            DismissalDate = dismissalDate;
        }
    }
}
