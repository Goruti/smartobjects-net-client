﻿using Mnubo.SmartObjects.Client.Impl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnubo.SmartObjects.Client.Test.Impl
{
    [TestFixture()]
    class ExistResultsDeserializerTest
    {
        [Test()]
        public void DeserializeExistResultTest()
        {
            string json = "[{\"id1\":true},{\"id2\":true},{\"id3\":false}]";
            IDictionary<string, bool> expected = new Dictionary<string, bool>()
            {
                { "id1", true },
                { "id2", true },
                { "id3", false }
            };

            Assert.AreEqual(expected, ExistResultsDeserializer.DeserializeExistResults(json));
        }
    }
}
