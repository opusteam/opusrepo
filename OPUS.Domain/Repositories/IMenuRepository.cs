﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IMenuRepository
    {
        List<Menu> GetMenuByUserName(string username);
    }
}
