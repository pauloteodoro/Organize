using FluentValidator;
using FluentValidator.Validation;
using PendingSchedule.Domain.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendingSchedule.Domain.Commands
{
   
    public class MarkPendingAsUndoneCommand : Notifiable, ICommand
    {
        public MarkPendingAsUndoneCommand()
        {
        }

        public MarkPendingAsUndoneCommand(Guid id, string user)
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
