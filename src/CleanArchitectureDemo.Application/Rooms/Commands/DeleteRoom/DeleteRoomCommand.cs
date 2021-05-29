using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitectureDemo.Application.Rooms.Commands.DeleteRoom
{
    public class DeleteRoomCommand : IRequest<bool>
    {
        public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, bool>
        {
            private readonly IApplicationDbContext _applicationDbContext;

            public DeleteRoomCommandHandler(IApplicationDbContext applicationDbContext)
            {
                _applicationDbContext = applicationDbContext;
            }

            public async Task<bool> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
