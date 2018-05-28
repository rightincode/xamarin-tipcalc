﻿using System;
using tipcalc_core.Interfaces;

namespace tipcalc_core.Models
{
    public class TipCalculator : ITipCalculator
    {
        private decimal tipPercent;

        public decimal Total { get; set; }

        public decimal Tip { get; set; }

        public decimal TipPercent
        {
            get { return tipPercent; }
            set { tipPercent = Math.Round(value); }
        }

        public decimal GrandTotal { get; private set; }

        public void CalcTip()
        {
            if (tipPercent > 0)
            {
                Tip = Math.Round(Total * (tipPercent / 100), 2);                
            }
            else
            {
                Tip = 0;
            }
            UpdateGrandTotal();
        }

        public void CalcTipPercentage()
        {
            if (Total > 0)
            {
                tipPercent = Math.Round((Tip / Total) * 100, 1);
            }
            else
            {
                tipPercent = 0;
            }

            UpdateGrandTotal();
        }
        
        private void UpdateGrandTotal()
        {
            GrandTotal = Total + Tip;
        }
    }
}
