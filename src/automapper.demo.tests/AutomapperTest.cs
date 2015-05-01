using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using automapper.demo;

namespace automapper.demo.tests
{
    [TestClass]
    public class AutomapperTest
    {
        [TestInitialize]
        public void Initialize()
        {
            AutomapperConfig.RegisterMappings();
        }

        [TestMethod]
        public void should_validate_mappings()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}
