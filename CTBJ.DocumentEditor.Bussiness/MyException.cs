﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.DocumentEditor.Bussiness
{
    public class MyException:Exception
    {
        public MyException(string message)
            : base(message)
        {
        }
    }
}
