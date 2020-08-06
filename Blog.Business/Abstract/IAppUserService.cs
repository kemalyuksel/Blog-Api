﻿using Blog.Dto.DTOs.AppUserDtos;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {

        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);

    }
}
