using PendingSchedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendingSchedule.Domain.Repositories
{
    public interface IPendingRepository
    {
        void Create(PendingItem item);

        void Update(PendingItem item);

    }
}
