﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using p2groep11.Net.Models.Domain;

namespace p2groep11.Net
{
    public class NW : Parameter
    {

        public NW()
        {
            
        }

        public NW(String beschr)
        {
            this.Beschrijving = beschr;
        }
        public override double Execute(ClimateChart chart)
        {
            return chart.RainInWinter;
        }

        public override string[] GiveOptAnswers(ClimateChart chart)
        {
            return chart.TotalRainfallInts();
        }

        public override string GiveAnswer(ClimateChart chart)
        {
            return chart.RainInWinter.ToString();
        }
    }
}
