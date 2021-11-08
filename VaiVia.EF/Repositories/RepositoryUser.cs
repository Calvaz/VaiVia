using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaVai.Core.Interfaces;

namespace VaiVia.EF.Repositories
{
    public class RepositoryUser : IRepositoryUser
    {
        private readonly VaiViaContext context;
        public RepositoryUser()
        {
            context = new VaiViaContext();
        }
    }
}
