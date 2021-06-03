using FluentValidator;
using PendingSchedule.Domain.Commands;
using PendingSchedule.Domain.Entities;
using PendingSchedule.Domain.Handlers.Contracts;
using PendingSchedule.Domain.Repositories;
using PendingSchedule.Domain.Shared;
using PendingSchedule.Domain.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendingSchedule.Domain.Handlers
{
    public class PendingHandler :
        Notifiable,
        IHandler<CreatePending>
    {

        private readonly IPendingRepository _repository;

        public PendingHandler(IPendingRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreatePending command)
        {
            command.Validate();

            if (command.Invalid)
                return new GenericCommandResult(false, "falha validação", command.Notifications);

            var pendingItem = new PendingItem(command.Title, command.Date, command.User, command.Description);

            _repository.Create(pendingItem);

            return new GenericCommandResult(true, "Tarefa salva com sucesso", pendingItem);
        }
    }
}
