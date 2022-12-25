using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayTestAPI.Models
{
    public class Register
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string AccountID { get; set; }
        public System.DateTime DOJ { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string Phone { get; set; }
        public string ConfirmationDOC { get; set; }
        public string UserAddress { get; set; }
        public string UserProfile { get; set; }
        public string UserPass { get; set; }
        public string WalletID { get; set; }
    }
}