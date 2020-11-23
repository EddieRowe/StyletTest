using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Principal;

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
            string user = Environment.UserName;
            // Capitalise first letters, remove dots, replace with spaces
            TestBinding = user;
            
            
        }

    }
}
