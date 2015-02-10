﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace p2groep11.Net.Models
{
    public class Grade
    {

        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                if (value > 0 && value <= 3)
                {
                    this.number = value;
                    
                }
                else throw new ArgumentException("Number needs to be between 1 and 3.");
            }
        }
        public Form From { get; set; }
    }
}