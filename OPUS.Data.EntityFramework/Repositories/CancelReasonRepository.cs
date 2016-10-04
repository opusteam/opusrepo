using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
   internal class CancelReasonRepository : Repository<CancelReason>,IcancelReasonRepository
    {
        internal CancelReasonRepository(ApplicationDbContext context)
            : base(context)
        {
        }


    }
   
 }
