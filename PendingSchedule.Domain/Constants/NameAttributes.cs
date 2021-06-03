using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendingSchedule.Domain.Constants
{
    class NameAttributes
    {
        public class PendingScheduleItem
        {
            public static readonly string TitlePendingScheduleItem = "title";
            public static readonly string DescriptionPendingScheduleItem = "description";
            public static readonly string UserPendingScheduleItem = "user";


            // Decidir de vale a pena colocar name e descrição das mensagens aqui 

            //public static readonly PendingScheduleItem TitlePendingScheduleItem = new PendingScheduleItem("title", "");
            //public static readonly PendingScheduleItem DescriptionPendingScheduleItem = new PendingScheduleItem("description", "");

            //public string Codigo { get; private set; }
            //public string mensagem { get; private set; }

            //private PendingScheduleItem(string codigo, string mensagem)
            //{
            //    this.Codigo = codigo;
            //    this.mensagem = mensagem;
            //}

        }

    }
}
