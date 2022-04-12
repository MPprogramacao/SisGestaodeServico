using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Login
    {
        private static String user = null;

        public static String User
        {
            get { return user; }
            set { user = value; }
        }
    }
}
