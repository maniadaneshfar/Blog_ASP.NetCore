using BlogTest.Application.Interfaces.Context;
using BlogTest.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BlogTest.Persistence.Contexts
{
    public class ApplicationDbContext: DbContext ,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        public int SaveChange(bool acceptAllChangesOnSuccess)
        {
            throw new NotImplementedException();
        }

        public int SaveChange()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangeAcync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangeAcync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
