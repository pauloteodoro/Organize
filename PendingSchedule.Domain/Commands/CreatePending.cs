
using FluentValidator;
using FluentValidator.Validation;
using PendingSchedule.Domain.Shared.Contracts;
using System;


namespace PendingSchedule.Domain.Commands
{
    public class CreatePending : Notifiable , ICommand
    {
        public CreatePending()
        {
        }

        public CreatePending(string title, string description, DateTime date, string user)
        {
            Title = title;
            Description = description;
            Date = date;
            User = user;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }

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
            );
        }
    }
}
