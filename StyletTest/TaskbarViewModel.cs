using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public TaskbarViewModel()
        {
            TestBinding = "binding1";
        }

        public void DoClick(object sender, EventArgs e)
        {
            
            TestBinding = "binding2";

        }

    }
}
