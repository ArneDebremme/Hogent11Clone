﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Linq;

namespace p2groep11.Net.Models.Domain
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public Boolean AboveEquator { get; set; }
        public virtual Continent Continent { get; set; }
        public virtual ICollection<ClimateChart> ClimateCharts { get; set; }

        public Country()
        {
            ClimateCharts = new List<ClimateChart>();
            AboveEquator = true;
        }

        public Country(String name, Continent c)
        {
            Name = name;
            Continent = c;
            ClimateCharts = new List<ClimateChart>();
            AboveEquator = true;
        }

        public ClimateChart GetClimateChart(int climateChartID )
        {
            ClimateChart c =ClimateCharts.FirstOrDefault(cl => cl.ClimateChartID == climateChartID);
            if (c != null)
                return c;
            else throw new ArgumentNullException("ClimateChart met " + climateChartID + " not found");
        }
    }
}
