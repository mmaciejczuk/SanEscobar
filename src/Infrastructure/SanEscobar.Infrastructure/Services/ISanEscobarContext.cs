using Microsoft.EntityFrameworkCore;
using SanEscobar.Domain.Core2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public interface ISanEscobarContext
    {
        DbSet<Player> Players { get; set; }
    }
}
