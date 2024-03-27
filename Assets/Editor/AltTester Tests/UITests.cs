using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

namespace Tests.AltTesterUnitySDK
{
    public class UITests
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
        public void MenuTest()
        {
            var leaderboardButton = altDriver.WaitForObject(By.NAME, "OpenLeaderboard");
            var storeButton = altDriver.WaitForObject(By.NAME, "StoreButton");
            var missionButton = altDriver.WaitForObject(By.NAME, "MissionButton");
            var settingsButton = altDriver.WaitForObject(By.NAME, "SettingButton");

            leaderboardButton.Click();
            var leaderboardCloseButton = altDriver.WaitForObject(By.PATH, "//Leaderboard/Background/Button");
            leaderboardCloseButton.Click();
            storeButton.Click();
            var storeCloseButton = altDriver.WaitForObject(By.PATH, "//Canvas/Background/Button");
            storeCloseButton.Click();
            missionButton.Click();
            var missionCloseButton = altDriver.WaitForObject(By.PATH, "//MissionPopup/MissionBackground/CloseButton");
            missionCloseButton.Click();
            settingsButton.Click();
            var settingsCloseButton = altDriver.WaitForObject(By.PATH, "//SettingPopup/Background/CloseButton");
            settingsCloseButton.Click();

            var startButton = altDriver.WaitForObject(By.NAME, "StartButton");
            startButton.Click();
        }

    }
}