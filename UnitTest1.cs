using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace FinalProject
{
    [TestClass]
    public class UnitTest1
    {
        TestClasses obj = new TestClasses();

        TestClasses.Login login = new TestClasses.Login();
        TestClasses.SearchPage searchPage = new TestClasses.SearchPage();
        TestClasses.BasePage basePage = new TestClasses.BasePage();
        TestClasses.AddRecordClass addObject = new TestClasses.AddRecordClass();
        TestClasses.Job addjob1 = new TestClasses.Job();
        TestClasses.subscribe subscribesite = new TestClasses.subscribe();
        TestClasses.Logout logout = new TestClasses.Logout();
        TestClasses.SearchEmployee seacchemploy = new TestClasses.SearchEmployee();
        TestClasses.AddEmployee addemployee = new TestClasses.AddEmployee();
        TestClasses.SearchDirectory searchDirectory = new TestClasses.SearchDirectory();
        TestClasses.Buzz buzz = new TestClasses.Buzz();
        TestClasses.Maintenance maintenance = new TestClasses.Maintenance();
        TestClasses.Performance performance = new TestClasses.Performance();
        TestClasses.Recruitment recruitment = new TestClasses.Recruitment();
        TestClasses.Time time = new TestClasses.Time();
        TestClasses.organization organize = new TestClasses.organization();
        TestClasses.Skills skills = new TestClasses.Skills();

        [TestMethod]
        public void Testcase01()
        {
            #region valid login
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase02()
        {
            #region Invalid login Without username 
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "", "admin123");
            string actualText = TestClasses.BasePage.driver.FindElement(By.Id("spanMessage")).Text;
            Assert.AreEqual("Username cannot be empty", actualText);
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();


            //addObject.AddRecord();
            #endregion
        }

        [TestMethod]
        public void Testcase03()
        {
            #region INvalid login Without Password
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "");

            string actualText = TestClasses.BasePage.driver.FindElement(By.Id("spanMessage")).Text;
            Assert.AreEqual("Password cannot be empty", actualText);
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase04()
        {
            #region INvalid login Without username with wrong span message
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "", "admin123");
            string actualText = TestClasses.BasePage.driver.FindElement(By.Id("spanMessage")).Text;
            Assert.AreEqual("Username can be empty", actualText);
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase05()
        {
            #region add user record and press save
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addObject.AddRecord("ESS", "Alice Duval", "Alice", "Enabled", "alice123", "alice123");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase06()
        {
            #region add user record and press delete
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addObject.DeleteRecord("ohrmList_chkSelectRecord_37");

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase07()
        {
            #region add user record without password
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            addObject.AddRecord("ESS", "Alice Duval", "Alice", "Enabled", "", "alice123");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase08()
        {
            #region add user record with wrong confirm password
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            addObject.AddRecord("ESS", "Alice Duval", "Alice", "Enabled", "alice123", "alice1234");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase09()
        {
            #region fill add user record then cancel
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            addObject.AddRecord("ESS", "Alice Duval", "Alice", "Enabled", "alice123", "alice123");
            TestClasses.BasePage.driver.FindElement(By.Id("btnCancel")).Click();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase10()
        {
            #region fill search user record and then press search 
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            searchPage.Search("	Aaliyah.Haq", "ESS", "Aaliyah Haq", "Enabled");
            TestClasses.BasePage.driver.FindElement(By.Id("searchBtn")).Click();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();

            #endregion 
        }

        [TestMethod]
        public void Testcase11()
        {
            #region  fill Search record details and then reset
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            searchPage.Search("	Aaliyah.Haq", "ESS", "Aaliyah Haq", "Enabled");
            TestClasses.BasePage.driver.FindElement(By.Id("resetBtn")).Click();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase12()
        {
            #region  Add job title and press save
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addjobrecord("Freelance", "freelance marketplace website, which allows potential employers to post jobs that freelancers can then bid to complete.", "C:\\Users\\Atif\\Desktop\\mind.jpg", " freelance marketplace website, which allows potential employers to post jobs ");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion 
        }

        [TestMethod]
        public void Testcase13()
        {
            #region  Add job title and press cancel
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addjobrecord("Freelance", "freelance marketplace website, which allows potential employers to post jobs that freelancers can then bid to complete.", "C:\\Users\\Atif\\Desktop\\mind.jpg", " freelance marketplace website, which allows potential employers to post jobs ");
            TestClasses.BasePage.driver.FindElement(By.Id("btnCancel")).Click();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase14()
        {
            #region  Delete any job title record
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.deletejobrecord("ohrmList_chkSelectRecord_1");

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase15()
        {
            #region  Add pay Grades and press save
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addPayGrade("muhammad atif");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase16()
        {
            #region  Add pay Grades and press cancel
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addPayGrade("muhammad atif");
            TestClasses.BasePage.driver.FindElement(By.Id("btnCancel")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase17()
        {
            #region  Add pay Grades and further add currency and press save
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addPayGradeWithCurrency("muhammad atif", "PKR", "5000", "10000");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSaveCurrency")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase18()
        {
            #region  Add pay Grades and further add currency and press cancel
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addPayGradeWithCurrency("muhammad atif", "PKR", "5000", "10000");
            TestClasses.BasePage.driver.FindElement(By.Id("cancelButton")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase19()
        {
            #region  Add jobstatus then  press save
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addJobStatus("Full-Time Contract");
            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase20()
        {
            #region  Add jobstatus then  press cancel
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addjob1.addJobStatus("Full-Time Contract");
            TestClasses.BasePage.driver.FindElement(By.Id("btnCancel")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase21()
        {
            #region  check about from welcome menu
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("welcome")).Click();
            TestClasses.BasePage.driver.FindElement(By.Id("aboutDisplayLink")).Click();
            TestClasses.BasePage.driver.FindElement(By.ClassName("close")).Click();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase22()
        {
            #region  check support from welcome menu 
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("welcome")).Click();
            Thread.Sleep(1000);
            TestClasses.BasePage.driver.FindElement(By.LinkText("Support")).Click();
            string actualText = TestClasses.BasePage.driver.FindElement(By.ClassName("head")).Text;
            Assert.AreEqual("Support", actualText);
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase23()
        {
            #region  add search then press search (postive)
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            seacchemploy.serachemployeefunction("Alice", "2034", "Freelance", "Current Employees only", "John Smith", " HR Manager", "Engineering");
            TestClasses.BasePage.driver.FindElement(By.Id("searchBtn")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase24()
        {
            #region  add search then press reset
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            seacchemploy.serachemployeefunction("Alice", "2034", "Freelance", "Current Employees only", "John Smith", " HR Manager", "Engineering");
            TestClasses.BasePage.driver.FindElement(By.Id("resetBtn")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase25()
        {
            #region  subscribe page without @ (negative testcase)
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            subscribesite.subscribefunction("ATIF", "atifgmailcom");

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase26()
        {
            #region  add employee then press save(postive)
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            addemployee.addemployeefunction("Alice", "Jame", "asghar", "-0027");
            TestClasses.BasePage.driver.FindElement(By.Id("photofile")).SendKeys("C:\\Users\\Atif\\Desktop\\mind.jpg");
            Thread.Sleep(1000);

            TestClasses.BasePage.driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(1000);

            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase27()
        {
            #region search record in directory and press search
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            searchDirectory.search("Odis Adalwin", "Chief Technical Officer", "HQ - CA, USA");
            TestClasses.BasePage.driver.FindElement(By.Id("searchBtn")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase28()
        {
            #region search record in directory and press reset 
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            searchDirectory.search("Odis Adalwin", "Chief Technical Officer", "HQ - CA, USA");
            TestClasses.BasePage.driver.FindElement(By.Id("resetBtn")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase29()
        {
            #region update buzz status and press post
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            buzz.updateBuzzStatus("Hi, I'm Muhammad Atif ,Please Join and Subscribe My Youtube Channel");
            TestClasses.BasePage.driver.FindElement(By.Id("postSubmitBtn")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase30()
        {
            #region update buzz image and press post
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            buzz.uploadBuzzImage();
            Thread.Sleep(5000);

            TestClasses.BasePage.driver.FindElement(By.Id("imageUploadBtn")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase31()
        {
            #region verify password and add employee name and press search
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            maintenance.accessRecords();
            TestClasses.BasePage.driver.FindElement(By.ClassName("search_employee")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase32()
        {
            #region verify password and add employee name and press search and then download
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            maintenance.accessRecords();
            Thread.Sleep(1000);
            TestClasses.BasePage.driver.FindElement(By.ClassName("search_employee")).Click();
            TestClasses.BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/input")).Click();
            TestClasses.BasePage.driver.FindElement(By.Id("modal_confirm")).Click();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase33()
        {
            #region  login with number in username
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin456766777777", "admin123");
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase34()
        {
            #region  Click marketplace and compare page
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            TestClasses.BasePage.driver.FindElement(By.Id("MP_link")).Click();
            string actualText = TestClasses.BasePage.driver.FindElement(By.Id("menu")).Text;
            Assert.AreEqual("OrangeHRM Addons", actualText);
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase35()
        {
            #region  subscribe page 
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            subscribesite.subscribefunction("Atif", "atif@gmail.com");
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase36()
        {
            #region  logout from site
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            logout.logoutsystem();
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase37()
        {
            #region  performance -- configure KPI and delete record
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            performance.Configure();
            Thread.Sleep(1000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase38()  
        {
            #region  Recuirtment Search
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            recruitment.search();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase39()
        {
            #region  Recuirtment Add
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            recruitment.add();
            
            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase40()
        {
            #region  time
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            time.TimeSheet();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase41()
        {
            #region organization
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            organize.Information();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }

        [TestMethod]
        public void Testcase42()
        {
            #region qualification
            basePage.SeleniumInit();
            login.LoginFunction("https://opensource-demo.orangehrmlive.com/", "Admin", "admin123");
            skills.addSkills();

            Thread.Sleep(2000);
            TestClasses.BasePage.driver.Close();
            #endregion
        }
    }
}