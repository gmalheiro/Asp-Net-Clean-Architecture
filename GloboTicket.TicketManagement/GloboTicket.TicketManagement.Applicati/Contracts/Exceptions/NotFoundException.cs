﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Applicati.Contracts.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key ) : base ($"{name} ({key}) is not found")
        {
        }
    }
}
