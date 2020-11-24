﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAppP5
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Keep track of Captcha random number until verified or timeout
            Random randomNum = new Random();
            Int32 captchaNum = randomNum.Next(100000, 999999);
            Session["Captcha"] = captchaNum.ToString();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Reset Capcha when Session ends
            //Clear session captcha
            Session["Captcha"] = null;
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}