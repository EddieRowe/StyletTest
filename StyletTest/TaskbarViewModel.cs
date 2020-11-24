using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Principal;
using System.ComponentModel;
using System.Globalization;

namespace StyletTest
{
    public class TaskbarViewModel : Screen
    {
        public string TestBinding 
        { 
            get { return testBinding; } 
            set { SetAndNotify(ref testBinding, value); } 
        }
        private string testBinding;

        private IWindowManager windowManager;

        public TaskbarViewModel(IWindowManager windowManager)
        {
            TestBinding = "binding1";
            this.windowManager = windowManager;
        }

        public void DoClick(object sender, EventArgs e)
        {
            // this would be checked via api, if null usr not logged in
            string username = Environment.UserName;

            username = username.Replace('.', ' ');
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            username = tI.ToTitleCase(username);

            TestBinding = username;
            
            
           
        }

    }
}
