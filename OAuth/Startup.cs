using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace OAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            // config.EnableCors(cors); //this is very important line cross orgin source(CORS)it is used to enable cross-site HTTP requests    
            ConfigureAuth(app);
        }
    }
}