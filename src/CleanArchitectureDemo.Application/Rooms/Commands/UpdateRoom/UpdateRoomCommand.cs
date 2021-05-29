using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitectureDemo.Application.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommand : IRequest<bool>
    {
        public class UpdateRoomCommandHandler: IRequestHandler<UpdateRoomCommand, bool>
        {
            private readonly IApplicationDbContext _applicationDbContext;

            public UpdateRoomCommandHandler(IApplicationDbContext applicationDbContext)
            {
                _applicationDbContext = applicationDbContext;
            }

            public async Task<bool> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
