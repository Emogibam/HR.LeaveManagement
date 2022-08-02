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
    public class LeaveTypeDetailRequestHandler : IRequestHandler<LeaveTypeDetailRequest, LeaveTypeDTO>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public LeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDTO> Handle(LeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.GetAsync(request.Id);
            return _mapper.Map<LeaveTypeDTO>(leaveType);
        }
    }
}
