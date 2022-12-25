using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PayTestAPI.Models;

namespace PayTestAPI.Controllers
{
    [RoutePrefix("api/users")]
    public class PayTestController : ApiController
    {
        PayTestDBEntities1 DB = new PayTestDBEntities1();


        [Route("Login")]
        [HttpPost]

        public IHttpActionResult UserLogin(Login login)
        {

            var log = DB.Users.Where(x => x.UserEmail.Equals(login.UserEmail) && x.UserPass.Equals(login.UserPass)).FirstOrDefault();

            if (log == null)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
            }
            else

                return Ok(new { status = 200, isSuccess = true, message = "User Login successfully", UserDetails = log });
        }

        [Route("InsertUser")]
        [HttpPost]
        public object InsertUser(Register Reg)
        {
            try
            {

                User UL  = new User();
                if (UL.UserID == 0)
                {

                    


                    UL.UserName = Reg.UserName;
                    UL.AccountID = Reg.AccountID;
                    UL.DOJ = Reg.DOJ;
                    UL.UserLastName = Reg.UserLastName;
                    UL.UserEmail = Reg.UserEmail;
                    UL.Phone = Reg.Phone;
                    UL.ConfirmationDOC = Reg.ConfirmationDOC;
                    UL.UserAddress = Reg.UserAddress;
                    UL.UserProfile = Reg.UserProfile;
                    UL.WalletID = Reg.WalletID;
                    UL.UserPass = Reg.UserPass;
                    DB.Users.Add(UL);
                    DB.SaveChanges();
                    return new Response
                    { Status = "Success", Message = "Record SuccessFully Saved." };
                }
            }
            catch (Exception ex)
            {
                return ("Exception: " + ex.Message);

                //throw;
            }
            return new Response
            { Status = "Error", Message = "Invalid Data." };
        }
    }
}
