﻿using BlogCore.Dao;
using BlogEntites.BlogDb;
using BlogEntities.BlogDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDataAccess.Abstract
{
    public interface IYorumDal : IEntityRepository<Yorum>
    {
    }
}
