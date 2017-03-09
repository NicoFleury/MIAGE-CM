using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;

namespace MIAGE.Exemple.Client
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ContactService.Contact, Models.ContactModel>()
                        .ForMember(dst => dst.PaysLibelle, opt => opt.ResolveUsing(src =>
                        {
                            var pays = Utils.Pays.FirstOrDefault(x => x.Id == src.PaysId);
                            return pays != null ? pays.Nom : string.Empty;
                        }));
                cfg.CreateMap<Models.ContactModel, ContactService.Contact>();
                cfg.CreateMap<PaysService.Pays, SelectListItem>().ConvertUsing(src =>
                {
                    return new SelectListItem()
                    {
                        Text = src.Nom,
                        Value = src.Id.ToString()
                    };
                });
        });
        }
}
}
