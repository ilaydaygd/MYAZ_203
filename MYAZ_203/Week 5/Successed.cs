﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_5
{
    public  class Successed: Result
    {
        public Successed(): base(true, "Successed")
        {

        }

        public Successed(string message): base(true,message)
        {

        }

    }
}
