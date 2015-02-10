﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using p2groep11.Net.Models;

namespace p2groep11.Net.Tests.Domein
{
    [TestClass]
    public class GradeTest
    {
        private Grade grade;
        [TestInitialize]
       public void InitGradeTest()
        {    
            grade = new Grade();
        }
        [TestMethod]
       public void setGraadSetsGraadl()        {
            grade.Number = 1;
            Assert.AreEqual(1,grade.Number);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Graad moet tussen 1 en 3 liggen")]
        public void graadKanNiet0zijn()
        {
            grade.Number = 0;
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException), "Graad moet tussen 1 en 3 liggen")]
        public void graadKanNiet4Zijn()
        {
            grade.Number = 4;
        }
        [TestMethod]
        [ExpectedException(typeof (ArgumentException), "Graad moet tussen 1 en 3 liggen")]
        public void graadKanNietGroterZijnDan3()        {
            grade.Number= 1200;
        }

        [TestMethod]
        public void setFormSetsFormIfGradeIs2()
        {
            grade.Number = 2;
            grade.From = Form.eerste;
            Assert.AreEqual(Form.eerste,grade.From);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException), "Grade.form throws exception als graad niet=2")]
        public void setFormThrowsExceptionWhenNot2()
        {
            grade.Number = 1;
            grade.From = Form.eerste;
        }
   }
}