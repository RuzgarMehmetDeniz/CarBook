using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands
{
    public class RemoveContactCommend
    {
        public int Id { get; set; }

        public RemoveContactCommend(int id)
        {
            Id = id;
        }
    }
}
