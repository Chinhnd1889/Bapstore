using System;

namespace Bapstore.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BapstoreDbContext Init();
    }
}
