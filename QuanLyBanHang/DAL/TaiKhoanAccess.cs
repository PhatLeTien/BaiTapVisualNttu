﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {
        public string CheckLogin(TaiKhoan taiKhoan)
        {
            string info = CheckLoginDTO(taiKhoan);
            return info;
        }
    }
}
