using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoMo.Model;

namespace MoMo
{
    public static class Session
    {
        public static User? LoggedInUserInfo { get; set; }
    }
}
