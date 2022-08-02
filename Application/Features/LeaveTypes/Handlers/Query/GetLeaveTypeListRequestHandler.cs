using Application.Contracts;
using Application.DTOs;
using Application.Features.LeaveTypes.Requests;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.LeaveTypes.Handlers.Query
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDTO>>
    {
        private readonly ILeaveTypeRepository _leaveType;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveType, IMapper mapper)
        {
            _leaveType = leaveType;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDTO>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes =  await _leaveType.GetAllAsync();
           return _mapper.Map<List<LeaveTypeDTO>>(leaveTypes);
            
        }
    }
}
