﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace p2groep11.Net.Models.Domain
{
    public class Result : ClauseComponent
    {
        public String Vegetationfeature { get; set; }
        public String Climatefeature { get; set; }
        public byte[] VegetationPicture { get; set; }

        public Result(String km, String vk, byte[] image)
        {
            Climatefeature = km;
            Vegetationfeature = vk;
            VegetationPicture = image;
        }

        public Result(String km,String vk)
        {
            Climatefeature = km;
            Vegetationfeature = vk;
        }

        public Result()
        {
            
        }

        public override string[] Determinate(ClimateChart chart)
        {
            return new string[] { Climatefeature, Vegetationfeature };
        }

        public override void CorrectPath(ClimateChart chart, List<ClauseComponent> cp)
        {
            cp.Add(this);
        }

        public override String GetHtmlCode(Boolean isYes)
        {
            if (isYes)
                return "<li><span class='YesSpan'><span class='glyphicon glyphicon-ok'>" + " " +Climatefeature + "</span></span></li>";
            else
            {
                return "<li><span class='NoSpan'><span class='glyphicon glyphicon-remove'>" + " " + Climatefeature + "</span></li>";
            }
        }

        public Image byteArrayToImage()
        {
            throw new NotImplementedException();
        }
    }
}
