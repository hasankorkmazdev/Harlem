﻿using Harlem.BLL.Abstract;
using Harlem.Core.Tools;
using Harlem.DAL.Abstract;
using Harlem.Entity.DbModels;
using Harlem.Entity.DTO.Users;

namespace Harlem.BLL.Concrete.Services
{
    public class UserManager : TemplateDataService<User, IUserDAL>, IUserService
    {
        public UserDTO CheckUser(UserLoginDTO model)
        {

            var data = _dataProvider.Get(x => x.Email == model.Email && x.Password == Extensions.Md5Hash(model.Password));
            if (data != null)
                return new UserDTO
                {
                    Id = data.Id,
                    Email = data.Email,
                    Name = data.Name,
                    Surname = data.Surname
                };
            else
                return null;
        }
    }
}
