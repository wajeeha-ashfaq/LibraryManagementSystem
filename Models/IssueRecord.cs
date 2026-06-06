using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Models
{
    public class IssueRecord
    {
        public int IssueID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public decimal FineAmount { get; set; }

        public int BookID { get; set; }

        public int StudentID { get; set; }
    }
}


