using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Commands.Players
{
    public class CreatePlayer : ICommand
    {
        public string ConnectionId { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }
    }
}
