using FluentValidator;
using FluentValidator.Validation;
using PendingSchedule.Domain.Shared.Contracts;
using System;

namespace PendingSchedule.Domain.Commands
{
    public class MarkPendingAsDoneCommand : Notifiable, ICommand
    {
        public MarkPendingAsDoneCommand()
        {
        }

        public MarkPendingAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }

        public void Validate()
        {
            AddNotifications(new ValidationContract()
                  .Requires()
                   .HasMinLen(
                           User,
                           5,
                           Constants.NameAttributes.PendingScheduleItem.UserPendingScheduleItem,
                           "Usuario deve ter no minimo 5 caracteres"
                     )
                );
        }
    }
}
