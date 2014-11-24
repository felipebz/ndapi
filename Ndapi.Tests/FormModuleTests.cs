using Ndapi;
using Ndapi.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndapi.Tests
{
    public class FormModuleTests
    {
        private FormModule _module;

        [SetUp]
        public void SetUp()
        {
            _module = new FormModule("TEST");
        }

        [TestCase("COMMENT")]
        public void Comment(String value)
        {
            _module.Comment = value;
            Assert.AreEqual(value, _module.Comment);
        }

        [TestCase("CONSOLE_WINDOW")]
        public void ConsoleWindow(String value)
        {
            _module.ConsoleWindow = value;
            Assert.AreEqual(value, _module.ConsoleWindow);
        }

        [Theory]
        public void DeferRequiredEnforcement(bool value)
        {
            _module.DeferRequiredEnforcement = value;
            Assert.AreEqual(value, _module.DeferRequiredEnforcement);
        }

        [Test, Ignore]
        public void FirstNavigationBlock(NdapiObject value)
        {
            // TODO
        }

        [TestCase("HELPBOOK_TITLE")]
        public void HelpBookTitle(String value)
        {
            _module.HelpBookTitle = value;
            Assert.AreEqual(value, _module.HelpBookTitle);
        }

        [TestCase("HORIZONTAL_TOOLBAR_CANVAS")]
        public void HorizontalToolbarCanvas(String value)
        {
            _module.HorizontalToolbarCanvas = value;
            Assert.AreEqual(value, _module.HorizontalToolbarCanvas);
        }

        [TestCase("INITIAL_MENU")]
        public void InitialMenu(String value)
        {
            _module.InitialMenu = value;
            Assert.AreEqual(value, _module.InitialMenu);
        }

        [Theory]
        public void InteractionMode(InteractionMode value)
        {
            _module.InteractionMode = value;
            Assert.AreEqual(value, _module.InteractionMode);
        }

        [Theory]
        public void IsolationMode(IsolationMode value)
        {
            _module.IsolationMode = value;
            Assert.AreEqual(value, _module.IsolationMode);
        }

        [Theory]
        public void LanguageDirection(LanguageDirection value)
        {
            _module.LanguageDirection = value;
            Assert.AreEqual(value, _module.LanguageDirection);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void MaximumQueryTime(int value)
        {
            _module.MaximumQueryTime = value;
            Assert.AreEqual(value, _module.MaximumQueryTime);
        }

        [TestCase(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MaximumQueryTime_InvalidValues(int value)
        {
            _module.MaximumQueryTime = value;
        }

        [TestCase(0)]
        [TestCase(1)]
        public void MaxRecordsFetched(int value)
        {
            _module.MaxRecordsFetched = value;
            Assert.AreEqual(value, _module.MaxRecordsFetched);
        }

        [TestCase(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MaxRecordsFetched_InvalidValues(int value)
        {
            _module.MaxRecordsFetched = value;
        }

        [TestCase("MENU_MODULE")]
        public void MenuModule(String value)
        {
            _module.MenuModule = value;
            Assert.AreEqual(value, _module.MenuModule);
        }

        [TestCase("MENU_ROLE")]
        public void MenuRole(String value)
        {
            _module.MenuRole = value;
            Assert.AreEqual(value, _module.MenuRole);
        }

        [Theory]
        public void MenuSource(MenuSource value)
        {
            _module.MenuSource = value;
            Assert.AreEqual(value, _module.MenuSource);
        }

        [Theory]
        public void MenuStyle(MenuStyle value)
        {
            _module.MenuStyle = value;
            Assert.AreEqual(value, _module.MenuStyle);
        }

        [Theory]
        public void MouseNavigationLimit(MouseNavigationLimit value)
        {
            _module.MouseNavigationLimit = value;
            Assert.AreEqual(value, _module.MouseNavigationLimit);
        }

        [Test, Ignore]
        public void CurrentRecordVisualAttribute(NdapiObject value)
        {
            // TODO
        }

        [Theory]
        public void RuntimeCompatibility(RuntimeCompatibility value)
        {
            _module.RuntimeCompatibility = value;
            Assert.AreEqual(value, _module.RuntimeCompatibility);
        }

        [TestCase("TITLE")]
        public void Title(String value)
        {
            _module.Title = value;
            Assert.AreEqual(value, _module.Title);
        }

        [Theory]
        public void Use3DControls(bool value)
        {
            _module.Use3DControls = value;
            Assert.AreEqual(value, _module.Use3DControls);
        }

        [Theory]
        public void ValidationUnit(ValidationUnit value)
        {
            _module.ValidationUnit = value;
            Assert.AreEqual(value, _module.ValidationUnit);
        }

        [TestCase("VERTICAL_TOOLBAR_CANVAS")]
        public void VerticalToolbarCanvas(String value)
        {
            _module.VerticalToolbarCanvas = value;
            Assert.AreEqual(value, _module.VerticalToolbarCanvas);
            _module.Save(@"C:\Users\Felipe\Desktop\teste.fmb");
        }
    }
}
