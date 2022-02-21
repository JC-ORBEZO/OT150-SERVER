﻿using OngProject.Entities;
using System;
using System.Threading.Tasks;

namespace OngProject.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<TestimonialsModel> TestimonialsModelRepository { get; }
        IRepository<MemberModel> MemberModelRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
