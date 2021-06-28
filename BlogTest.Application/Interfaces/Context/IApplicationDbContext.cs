using BlogTest.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTest.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        int SaveChange(bool acceptAllChangesOnSuccess);
        int SaveChange();
        Task<int> SaveChangeAcync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken= new  CancellationToken());
        Task<int> SaveChangeAcync(CancellationToken cancellationToken = new CancellationToken());


    }
}
