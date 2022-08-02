using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class LeaveAllocationDTO : BaseDTOs
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
