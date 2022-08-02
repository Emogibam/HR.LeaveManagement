using Application.Contracts;
using Application.DTOs;
using Application.Features.LeaveAllocation.Requests.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationDetailRequesthandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDTO>
    {
        private readonly ILeaveAllocation _allocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequesthandler(ILeaveAllocation allocationRepository, IMapper mapper)
        {
            _allocationRepository = allocationRepository;
            _mapper = mapper;
        }
        public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _allocationRepository.GetAsync(request.Id);
            return _mapper.Map<LeaveAllocationDTO>(leaveAllocation);
        }
    }
}
