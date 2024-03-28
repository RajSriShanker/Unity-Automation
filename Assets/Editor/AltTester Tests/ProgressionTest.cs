using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;
using System.Threading;

namespace Tests.AltTesterUnitySDK
{
    public class ProgressionTest
    {   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
        public AltDriver altDriver;
        //Before any test it connects with the socket
        [OneTimeSetUp]
        public void SetUp()
        {
            altDriver = new AltDriver();
        }

        //At the end of the test closes the connection with the socket
        [OneTimeTearDown]
        public void TearDown()
        {
            altDriver.Stop();
        }

        [Test]
        public void CompleteRunTest()
        {
            var startButton = altDriver.WaitForObject(By.NAME, "StartButton");
            startButton.Click();
            
            altDriver.WaitForObject(By.NAME, "Life");

            Thread.Sleep(5000);
            altDriver.PressKey(AltKeyCode.LeftArrow);
            Thread.Sleep(2000);
            altDriver.PressKey(AltKeyCode.RightArrow);
            Thread.Sleep(2000);
            altDriver.PressKey(AltKeyCode.UpArrow);
            Thread.Sleep(2000);
            altDriver.PressKey(AltKeyCode.DownArrow);
            Thread.Sleep(2000);

            altDriver.WaitForObject(By.PATH, "//DeathPopup/Text");

            var gameOverButton = altDriver.WaitForObject(By.NAME, "GameOver");
            gameOverButton.Click();

            var runButton = altDriver.WaitForObject(By.NAME, "RunButton");
            runButton.Click();

            Assert.NotNull(startButton);
        }

    }
}