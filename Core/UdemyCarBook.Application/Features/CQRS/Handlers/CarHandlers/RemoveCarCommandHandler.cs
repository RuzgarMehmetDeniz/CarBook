using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly IRepository<Car> _repositories;

        public RemoveCarCommandHandler(IRepository<Car> repositories)
        {
            _repositories = repositories;
        }
        public async Task Handle (RemoveCarCommand command)
        {
            var value = await _repositories.GetByIdAsync(command.Id);
            await _repositories.RemoveAsync(value);

        }
    }
}
