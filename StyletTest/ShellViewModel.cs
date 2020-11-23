using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyletTest
{
    public class ShellViewModel : Screen
    {
        public TaskbarViewModel Taskbar { get; private set; }
        public ShellViewModel(TaskbarViewModel taskbarViewModel)
        {
            this.DisplayName = "Stylet Test Stuff";
            this.Taskbar = taskbarViewModel;
        }
    }
}
