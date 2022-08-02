using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDTO>>
    {
    }
}
