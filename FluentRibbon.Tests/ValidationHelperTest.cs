using FluentRibbon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using FluentRibbon.Definitions;

namespace FluentRibbon.Tests
{


    /// <summary>
    ///This is a test class for ValidationHelperTest and is intended
    ///to contain all ValidationHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ValidationHelperTest
    {
        #region ArrayField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckArrayTest1()
        {
            // ArrayField is null
            RibbonDefinition obj = new ValidationHelperTester();
            ValidationHelper.Current.CheckArrayHasElements(obj, "ArrayField");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckArrayTest2()
        {
            // ArrayField is empty array
            RibbonDefinition obj = new ValidationHelperTester() { ArrayField = new TabDefinition[] { } };
            ValidationHelper.Current.CheckArrayHasElements(obj, "ArrayField");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckArrayTest3()
        {
            // ArrayField filled properly
            RibbonDefinition obj = new ValidationHelperTester() { ArrayField = new TabDefinition[] { new TabDefinition() } };
            ValidationHelper.Current.CheckArrayHasElements(obj, "ArrayField");
        }

        #endregion

        #region RangeField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckIntRangeTest1()
        {
            // RangeField is null
            RibbonDefinition obj = new ValidationHelperTester();
            ValidationHelper.Current.CheckIntRange(obj, "RangeField", 1, 9);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckIntRangeTest2()
        {
            // RangeField is outside of the range
            RibbonDefinition obj = new ValidationHelperTester() { RangeField = -1 };
            ValidationHelper.Current.CheckIntRange(obj, "RangeField", 1, 9);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckIntRangeTest3()
        {
            // RangeField is in range
            RibbonDefinition obj = new ValidationHelperTester() { RangeField = 5 };
            ValidationHelper.Current.CheckIntRange(obj, "RangeField", 1, 9);
        }

        #endregion

        #region RequiredField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRequiredTest1()
        {
            // RequiredField is null
            RibbonDefinition obj = new ValidationHelperTester();
            ValidationHelper.Current.CheckNotNull(obj, "RequiredField");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckRequiredTest2()
        {
            // RequiredField is not null
            RibbonDefinition obj = new ValidationHelperTester() { RequiredField = String.Empty };
            ValidationHelper.Current.CheckNotNull(obj, "RequiredField");

        }

        #endregion

        #region RegexField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest1()
        {
            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester();
            ValidationHelper.Current.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest2()
        {
            // RegexField has invalid characters
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "Bad.Test" };
            ValidationHelper.Current.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckRegularExpressionTest3()
        {
            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "GoodTest" };
            ValidationHelper.Current.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest4()
        {
            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "Good Test" };
            ValidationHelper.Current.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");
        }

        #endregion
    }
}
