using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MIAGE.Exemple.WCF
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<BLL.Pays, DataContract.Pays>();
                cfg.CreateMap<BLL.Contact, DataContract.Contact>()
                    .ForMember(dst => dst.PaysId, obj => obj.ResolveUsing(src => src.Pays.Id));
                cfg.CreateMap< DataContract.Contact, BLL.Contact>();
            });


        }

        protected void Session_Start(object sender, EventArgs e)
        {

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

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}