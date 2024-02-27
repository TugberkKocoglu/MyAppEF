using MyApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Business
{
    public class Operations
    {
        public bool AddApp(App app)
        {
			try
			{
				using (MyAppContext context = new MyAppContext())
				{
					context.Apps.Add(app);
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{

				return false;
			}
        }

		public List<App> GetAllApps()
		{
			using (MyAppContext context= new MyAppContext())
			{
				List<App> apps = context.Apps.ToList();
				
				return apps;
			}
			
		}

        public App GetApp(string appName)
		{
			using(MyAppContext context= new MyAppContext())
			{
                App app = context.Apps.FirstOrDefault(a=>a.AppName==appName);
				return app;

            }
			 
		}


        public List<string> FillApps()
        {
            using (MyAppContext context = new MyAppContext())
            {
                var apps=context.Apps.Select(a => a.AppName).ToList();
				return apps;
            }

        }

		public void DeleteApp(string appName)
		{
			using (MyAppContext context=new MyAppContext())
			{
				var app= context.Apps.FirstOrDefault(a=>a.AppName==appName);
				context.Apps.Remove(app);
				context.SaveChanges() ;
			}
		}

		public void UpdateApp(string appName,string userName,string password)
		{
			using (MyAppContext context=new MyAppContext())
			{
				var app = context.Apps.FirstOrDefault(a => a.AppName == appName);
				app.UserName= userName;
				app.Password= password;
				context.SaveChanges();
				
			}
		}
		
    }
}
