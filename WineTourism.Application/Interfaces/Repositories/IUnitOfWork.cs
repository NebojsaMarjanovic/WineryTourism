﻿using WineTourism.Domain.Common;

namespace WineTourism.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity;
        Task<int> Save(CancellationToken cancellationToken);
        Task Rollback();
    }
}