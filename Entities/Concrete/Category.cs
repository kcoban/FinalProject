﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    public class Category : IEntity
    {



        public string CategoryName { get; set; }
    }
}
