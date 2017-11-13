using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineDBProject {
    public class UserSession {
        public static UserSession ActiveSession { get; set; }

        public string ActiveUser { get; set; }
        public HomeForm ActiveHomeForm { get; }
        public LoginForm ActiveLoginForm { get; }

        public UserSession(HomeForm hf, LoginForm lf) {
            this.ActiveHomeForm = hf;
            this.ActiveLoginForm = lf;
        }
    }
}
