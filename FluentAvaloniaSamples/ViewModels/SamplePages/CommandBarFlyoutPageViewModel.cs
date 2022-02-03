﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAvaloniaSamples.Utilities;

namespace FluentAvaloniaSamples.ViewModels
{
    public class CommandBarFlyoutPageViewModel : ViewModelBase
    {
        public CommandBarFlyoutPageViewModel()
        {
            FlyoutCommands = new FACommand(Execute);
        }

        public FACommand FlyoutCommands { get; }

        public void Execute(object @param)
        {
            LastAction = param.ToString();
            RaisePropertyChanged(nameof(LastAction));
        }

        private string LastAction { get; set; }
    }
}