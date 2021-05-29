using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitectureDemo.Application.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommand : IRequest<int>
    {
        public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
        {
            private readonly IApplicationDbContext _applicationDbContext;

            public CreateRoomCommandHandler(IApplicationDbContext applicationDbContext)
            {
                _applicationDbContext = applicationDbContext;
            }

            public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
