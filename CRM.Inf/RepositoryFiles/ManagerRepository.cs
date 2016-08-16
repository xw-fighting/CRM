﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Data.Dto;
using CRM.Model.Interfaces;

namespace CRM.Inf.RepositoryFiles
{
    class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(DbContext context)
            : base(context)
        {
        }
    }
}