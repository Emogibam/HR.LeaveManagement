using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class LeaveTypeDTO: BaseDTOs
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
