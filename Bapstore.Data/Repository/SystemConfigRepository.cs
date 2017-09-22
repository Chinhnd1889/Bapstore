﻿using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;

namespace Bapstore.Data.Repository
{
    public interface ISystemConfigRepository { }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
