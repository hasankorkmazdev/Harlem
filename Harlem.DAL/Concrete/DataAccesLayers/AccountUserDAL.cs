﻿using Harlem.DAL.Abstract;
using Harlem.DAL.Concrete.DataAccesLayers.Template;
using Harlem.Entity.DbModels;
using Harlem.Entity.DTO.Users;

namespace Harlem.DAL.Concrete.DataAccesLayers
{
    public class AccountUserDAL : DataAccessTemplate<Context.HarlemContext, AccountUser>, IAccountUserDAL
    {
       
    }

}
