﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands
{
    public class RemoveAdvanceCommand
    {
        public int Id { get; set; }

        public RemoveAdvanceCommand(int id)
        {
            Id = id;
        }
    }
}
