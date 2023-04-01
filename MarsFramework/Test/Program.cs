using ICSharpCode.SharpZipLib.Core;
using MarsFramework.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            #region Test 1: EnterShareSkill
            [Test, Order (1)]
            public void EnterShareSkill()
            {
                //Starts the report
                test = extent.StartTest("EnterShareSkil");
                test.Log(LogStatus.Info, "ShareSkills Record created");

                //Take screenshots of entering share skills
                SaveScreenShotClass.SaveScreenshot(driver,"ShareSkills");

                //Enter New Share Skill steps
                ShareSkill shareSkillObj = new ShareSkill();
                shareSkillObj.EnterShareSkillSteps();

            }
            #endregion
        }
    }
}