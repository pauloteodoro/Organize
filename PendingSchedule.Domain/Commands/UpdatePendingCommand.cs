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
    class UpdatePendingCommand : Notifiable, ICommand
    {

        public UpdatePendingCommand()
        {
        }

        public UpdatePendingCommand(Guid id, string title, string user, string description)
        {
            Id = id;
            Title = title;
            User = user;
            Description = description;
        }


        public Guid Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
        public string Description { get; set; }


        public void Validate()
        {
            AddNotifications(new ValidationContract()
                    .Requires()
                    .HasMinLen(
                           Title,
                           3,
                           Constants.NameAttributes.PendingScheduleItem.TitlePendingScheduleItem,
                           "Title deve ter no minimo 3 caracteres"
                     )
                    .HasMaxLen(
                        Title,
                        100,
                        Constants.NameAttributes.PendingScheduleItem.TitlePendingScheduleItem,
                        "Titulo deve ter no maximo 100 caracteres"
                    )
                    .HasMinLen(
                           User,
                           5,
                           Constants.NameAttributes.PendingScheduleItem.UserPendingScheduleItem,
                           "Usuario deve ter no minimo 5 caracteres"
                     )
                    .HasMinLen(
                           Description,
                           10,
                           Constants.NameAttributes.PendingScheduleItem.TitlePendingScheduleItem,
                           "Descroição  deve ter no minimo 10 caracteres"
                     )
        }
    }
}
