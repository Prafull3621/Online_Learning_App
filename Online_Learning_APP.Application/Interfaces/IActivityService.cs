﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Learning_APP.Application.DTO;

namespace Online_Learning_APP.Application.Interfaces
{
    public interface IActivityService
    {
        Task<ActivityDto> CreateActivityAsync(CreateActivityDto createActivity);
    }
}
