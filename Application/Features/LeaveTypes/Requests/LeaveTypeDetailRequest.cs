using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.LeaveTypes.Requests
{
    public class LeaveTypeDetailRequest  : IRequest<LeaveTypeDTO>
    {
        public int Id { get; set; }
    }
}
