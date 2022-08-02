using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveRequest
{
    public class ListLeaveRequestDTO :BaseDTOs
    {
        public LeaveTypeDTO LeaveType { get; set; }
       public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
