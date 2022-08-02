using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.LeaveAllocation.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, BaseCommandResponse>
    {
    }
}
