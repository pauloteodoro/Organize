using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendingSchedule.Domain.Entities
{
    class PendingScheduleItem : Entity
    {
        public PendingScheduleItem(string title, DateTime date, string user ,string description)
        {
            Title = title;
            Done = false;
            Date = date;
            User = user;
            Description = description;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }


        public void MarkAsDone()
        {
            Done = true;
        }

        public void MarkAsUndone()
        {
            Done = false;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }

        
    }
}
