using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitectureDemo.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Application.Rooms.Queries.GetRooms
{
    public class GetRoomsQuery : IRequest<RoomsVm>
    {
        public class GetRoomsQueryHandler : IRequestHandler<GetRoomsQuery, RoomsVm>
        {
            private readonly IApplicationDbContext _applicationDbContext;
            private readonly IMapper _mapper;

            public GetRoomsQueryHandler(IApplicationDbContext applicationDbContext,
                IMapper mapper)
            {
                _applicationDbContext = applicationDbContext;
                _mapper = mapper;
            }

            public async Task<RoomsVm> Handle(GetRoomsQuery request, CancellationToken cancellationToken)
            {
                var rooms = await _applicationDbContext.Rooms
                    .ProjectTo<RoomDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                return new RoomsVm()
                {
                    Rooms = rooms
                };
            }
        }
    }
}
