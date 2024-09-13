using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordCheckerApp; // Убедитесь, что пространство имен корректно

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
            // Пароль соответствует всем критериям
            string password = "Password1!";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void Password_OnlyDigitsAndLength_ScoreShouldBe2()
        {
            // Пароль содержит только цифры и более 7 символов
            string password = "12345678";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void Password_OnlyLowercaseAndLength_ScoreShouldBe2()
        {
            // Пароль содержит только строчные буквы и более 7 символов
            string password = "password";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void Password_OnlyUppercaseAndSpecial_ScoreShouldBe2()
        {
            // Пароль содержит только заглавные буквы и спец. символы
            string password = "PASSWORD!";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void Password_NoCriteriaMet_ScoreShouldBe0()
        {
            // Пустой пароль
            string password = "";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void Password_OnlySpecialCharactersAndLength_ScoreShouldBe2()
        {
            // Пароль содержит только спец. символы и более 7 символов
            string password = "@@@@!!!!";
            int score = passwordChecker.CheckPassword(password);
            Assert.AreEqual(2, score);
        }
    }
}
