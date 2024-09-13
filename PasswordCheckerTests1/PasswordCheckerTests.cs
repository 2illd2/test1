using PasswordCheckerApp;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordCheckerApp.Tests
{
    [TestClass]
    public class CheckTests
    {
        private PasswordChecker passwordChecker;

        [TestInitialize]
        public void Setup()
        {
            passwordChecker = new PasswordChecker();
        }

        [TestMethod]
        public void Password_AllCriteriaMet_ScoreShouldBe5()
        {
            string password = "Password1!";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(5, score);  
        }

        [TestMethod]
        public void Password_OnlyDigitsAndLength_ScoreShouldBe1()
        {
            string password = "12345678";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void Password_OnlyLowercaseAndLength_ScoreShouldBe1() 
        {
            string password = "password";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void Password_OnlyUppercaseAndSpecial_ScoreShouldBe1() 
        {
            string password = "PASSWORD!";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void Password_NoCriteriaMet_ScoreShouldBe1() 
        {
            string password = "";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void Password_OnlySpecialCharactersAndLength_ScoreShouldBe1() 
        {
            string password = "@@@@!!!!";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(1, score);
        }
    }
}
