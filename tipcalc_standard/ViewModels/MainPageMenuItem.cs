﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipcalc_standard.ViewModels
{

    public class MainPageMenuItem
    {
        public MainPageMenuItem()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public bool IsEnabled { get; set; }

        public Type TargetType { get; set; }
    }
}