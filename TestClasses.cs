using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject
{
    class TestClasses
    {
        public class Login : BasePage
        {
            #region login function

            public void LoginFunction(string url, string user, string pass)
            {
                driver.Url = url;
                driver.Manage().Window.Maximize();

                //fill login details
                driver.FindElement(By.Id("txtUsername")).SendKeys(user);
                driver.FindElement(By.Id("txtPassword")).SendKeys(pass);

                //click lpgin button
                driver.FindElement(By.ClassName("button")).Click();
            }
            #endregion
        }

        public class Logout
        {
            #region logout from system
            public void logoutsystem()
            {
                BasePage.driver.FindElement(By.Id("welcome")).Click();
                Thread.Sleep(1000);

                BasePage.driver.FindElement(By.LinkText("Logout")).Click();
                Thread.Sleep(2000);
            }
            #endregion
        }

        public class BasePage
        {
            #region Driverfunction
            public static IWebDriver driver;
            public void SeleniumInit()
            {
                var myDriver = new ChromeDriver();
                driver = myDriver;
            }
            #endregion
        }

        public class SearchPage
        {
            #region search function
            public void Search(string user, string role, string employee, string status)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();

                //fill search form
                BasePage.driver.FindElement(By.Id("searchSystemUser_userName")).SendKeys(user);
                BasePage.driver.FindElement(By.Id("searchSystemUser_userType")).SendKeys(role);
                BasePage.driver.FindElement(By.Id("searchSystemUser_employeeName_empName")).SendKeys(employee);
                BasePage.driver.FindElement(By.Id("searchSystemUser_status")).SendKeys(status);

            }
            #endregion
        }

        public class AddRecordClass
        {
            #region Addrecord function
            public void AddRecord(string role, string employee, string user, String status, string pass, string confpass)
            {
                //click Admin tab button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();

                //click add button
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();

                //fill form
                BasePage.driver.FindElement(By.Id("systemUser_userType")).SendKeys(role);
                BasePage.driver.FindElement(By.Id("systemUser_employeeName_empName")).SendKeys(employee);
                BasePage.driver.FindElement(By.Id("systemUser_userName")).SendKeys(user);
                BasePage.driver.FindElement(By.Id("systemUser_status")).SendKeys(status);
                BasePage.driver.FindElement(By.Id("systemUser_password")).SendKeys(pass);
                BasePage.driver.FindElement(By.Id("systemUser_confirmPassword")).SendKeys(confpass);
            }
            #endregion

            #region Delete Record function
            public void DeleteRecord(string record)
            {
                //click Admin tab button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();

                //fill form
                BasePage.driver.FindElement(By.Id(record)).Click();
                BasePage.driver.FindElement(By.Id("btnDelete")).Click();
                BasePage.driver.FindElement(By.Id("dialogDeleteBtn")).Click();
            }
            #endregion
        }


        public class Job
        {
            #region Add job detail
            public void addjobrecord(string title, string JobDescrip, string addfile, string note)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Job")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_viewJobTitleList")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();

                BasePage.driver.FindElement(By.Id("jobTitle_jobTitle")).SendKeys(title);
                BasePage.driver.FindElement(By.Id("jobTitle_jobDescription")).SendKeys(JobDescrip);
                BasePage.driver.FindElement(By.Id("jobTitle_jobSpec")).SendKeys(addfile);
                BasePage.driver.FindElement(By.Id("jobTitle_note")).SendKeys(note);
            }
            #endregion

            #region Delete job detail
            public void deletejobrecord(string record)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Job")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_viewJobTitleList")).Click();

                BasePage.driver.FindElement(By.Id(record)).Click();
                BasePage.driver.FindElement(By.Id("btnDelete")).Click();
                BasePage.driver.FindElement(By.Id("dialogDeleteBtn")).Click();
            }
            #endregion

            #region Add pay Grades
            public void addPayGrade(string name)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Job")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_viewPayGrades")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();

                BasePage.driver.FindElement(By.Id("payGrade_name")).SendKeys(name);
            }
            #endregion

            #region Add pay Grades and then add currency
            public void addPayGradeWithCurrency(string name, string currency, string minimunSalary, string maximumSalary)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Job")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_viewPayGrades")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();

                //fill paygrade name
                BasePage.driver.FindElement(By.Id("payGrade_name")).SendKeys(name);
                BasePage.driver.FindElement(By.Id("btnSave")).Click();

                //fill currency detais
                BasePage.driver.FindElement(By.Id("btnAddCurrency")).Click();
                BasePage.driver.FindElement(By.Id("payGrade_name")).SendKeys(currency);
                BasePage.driver.FindElement(By.Id("payGrade_name")).SendKeys(minimunSalary);
                BasePage.driver.FindElement(By.Id("payGrade_name")).SendKeys(maximumSalary);
            }
            #endregion

            #region Add Employee status detail
            public void addJobStatus(string jobstatus)
            {
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Job")).Click();

                BasePage.driver.FindElement(By.Id("menu_admin_employmentStatus")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();
                BasePage.driver.FindElement(By.Id("empStatus_name")).SendKeys(jobstatus);
            }
            #endregion
        }

        public class subscribe
        {
            #region subscribe
            public void subscribefunction(string name, string email)
            {
                BasePage.driver.FindElement(By.Id("Subscriber_link")).Click();
                BasePage.driver.FindElement(By.Id("subscriber_name")).SendKeys(name);
                BasePage.driver.FindElement(By.Id("subscriber_email")).SendKeys(email);
                BasePage.driver.FindElement(By.Id("btnSubscribe")).Click();
            }
            #endregion
        }

        public class SearchEmployee
        {
            #region search employee record
            public void serachemployeefunction(string name, string id, string status, string jobtime, string supervisor, string title, string subtitle)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_pim_viewPimModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_pim_viewEmployeeList")).Click();

                //fill search form
                BasePage.driver.FindElement(By.Id("empsearch_employee_name_empName")).SendKeys(name);
                BasePage.driver.FindElement(By.Id("empsearch_id")).SendKeys(id);
                BasePage.driver.FindElement(By.Id("empsearch_employee_status")).SendKeys(status);
                BasePage.driver.FindElement(By.Id("empsearch_termination")).SendKeys(jobtime);
                BasePage.driver.FindElement(By.Id("empsearch_supervisor_name")).SendKeys(supervisor);
                BasePage.driver.FindElement(By.Id("empsearch_job_title")).SendKeys(title);
                BasePage.driver.FindElement(By.Id("empsearch_sub_unit")).SendKeys(subtitle);

            }
            #endregion
        }

        public class AddEmployee
        {
            #region add employee record
            public void addemployeefunction(string fname, string midname, string lname, string id)
            {
                //click admin button
                BasePage.driver.FindElement(By.Id("menu_pim_viewPimModule")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();

                //fill search form
                BasePage.driver.FindElement(By.Id("firstName")).SendKeys(fname);
                BasePage.driver.FindElement(By.Id("middleName")).SendKeys(midname);
                BasePage.driver.FindElement(By.Id("lastName")).SendKeys(lname);
                BasePage.driver.FindElement(By.Id("employeeId")).SendKeys(id);
            }
            #endregion
        }

        public class SearchDirectory
        {
            #region search record in directory
            public void search(string employeeName , string jobTitle , string location)
            {
                BasePage.driver.FindElement(By.Id("menu_directory_viewDirectory")).Click();

                BasePage.driver.FindElement(By.Id("searchDirectory_emp_name_empName")).SendKeys(employeeName);
                BasePage.driver.FindElement(By.Id("searchDirectory_job_title")).SendKeys(jobTitle);
                BasePage.driver.FindElement(By.Id("searchDirectory_location")).SendKeys(location);
            }
            #endregion
        }

        public class Buzz
        {
            #region update buzz status and press post
            public void updateBuzzStatus(string content)
            {
                BasePage.driver.FindElement(By.Id("menu_buzz_viewBuzz")).Click();
                BasePage.driver.FindElement(By.Id("tabLink1")).Click();
                BasePage.driver.FindElement(By.Id("createPost_content")).SendKeys(content);
            }
            #endregion

            #region upload buzz images and press post
            public void uploadBuzzImage()
            {
                BasePage.driver.FindElement(By.Id("menu_buzz_viewBuzz")).Click();
                BasePage.driver.FindElement(By.Id("tabLink2")).Click();
                BasePage.driver.FindElement(By.Id("image-upload-button")).Click();
            }
            #endregion
        }

        public class Maintenance
        {
            #region enter password and download specific persons data in maintenance Tab
            public void accessRecords()
            {
                BasePage.driver.FindElement(By.Id("menu_maintenance_purgeEmployee")).Click();
                BasePage.driver.FindElement(By.Id("menu_maintenance_accessEmployeeData")).Click();
                BasePage.driver.FindElement(By.Id("confirm_password")).SendKeys("admin123");
                BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/form/div/div/input")).Click();
                BasePage.driver.FindElement(By.Id("employee_empName")).SendKeys("Aaliyah Haq");
            }
            #endregion
        }

        public class Time
        {
            public void TimeSheet()
            {
                BasePage.driver.FindElement(By.Id("menu_time_viewTimeModule")).Click();
                BasePage.driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[2]/form/table/tbody/tr[4]/td[3]/a")).Click();
                BasePage.driver.FindElement(By.Id("btnEdit")).Click();
                BasePage.driver.FindElement(By.Id("submitSave")).Click();
                BasePage.driver.FindElement(By.Id("txtComment")).SendKeys("Done");
                BasePage.driver.FindElement(By.Id("btnApprove")).Click();
            }
        }

        public class Performance
        {
            public void Configure()
            {
                BasePage.driver.FindElement(By.Id("menu__Performance")).Click();
                BasePage.driver.FindElement(By.Id("menu_performance_Configure")).Click();
                BasePage.driver.FindElement(By.Id("menu_performance_searchKpi")).Click();
                BasePage.driver.FindElement(By.Id("kpi360SearchForm_jobTitleCode")).SendKeys("Account Assistant");
                BasePage.driver.FindElement(By.Id("ohrmList_chkSelectRecord_15")).Click();
                BasePage.driver.FindElement(By.Id("btnDelete")).Click();
                BasePage.driver.FindElement(By.ClassName("btn")).Click();
            }
        }

        public class Recruitment
        {
            public void search()
            {
                BasePage.driver.FindElement(By.Id("menu_recruitment_viewRecruitmentModule")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_jobTitle")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_jobTitle")).SendKeys("QA Lead");
                BasePage.driver.FindElement(By.Id("candidateSearch_jobVacancy")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_jobVacancy")).SendKeys("Associate IT Manager");
                BasePage.driver.FindElement(By.Id("candidateSearch_hiringManager")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_hiringManager")).SendKeys("Odis Adalwin");
                BasePage.driver.FindElement(By.Id("candidateSearch_status")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_status")).SendKeys("JOB OFFERED");
                BasePage.driver.FindElement(By.Id("candidateSearch_candidateName")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_candidateName")).SendKeys("Charles Haywire");
                BasePage.driver.FindElement(By.Id("candidateSearch_keywords")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_keywords")).SendKeys(",,,");
                BasePage.driver.FindElement(By.Id("candidateSearch_fromDate")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_fromDate")).SendKeys("2022-06-09");
                BasePage.driver.FindElement(By.Id("candidateSearch_toDate")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_toDate")).SendKeys("2022-06-15");
                BasePage.driver.FindElement(By.Id("candidateSearch_modeOfApplication")).Click();
                BasePage.driver.FindElement(By.Id("candidateSearch_modeOfApplication")).SendKeys("Manual");
                BasePage.driver.FindElement(By.Id("btnSrch")).Click();
            }

            public void add()
            {
                BasePage.driver.FindElement(By.Id("menu_recruitment_viewRecruitmentModule")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();
                BasePage.driver.FindElement(By.Id("addCandidate_firstName")).SendKeys("Hassan");
                BasePage.driver.FindElement(By.Id("addCandidate_middleName")).SendKeys("Ali");
                BasePage.driver.FindElement(By.Id("addCandidate_lastName")).SendKeys("Gohar");
                BasePage.driver.FindElement(By.Id("addCandidate_email")).SendKeys("hasankhan545454@gmail.com");
                BasePage.driver.FindElement(By.Id("addCandidate_contactNo")).SendKeys("03079286358");
                BasePage.driver.FindElement(By.Id("addCandidate_vacancy")).Click();
                BasePage.driver.FindElement(By.Id("addCandidate_vacancy")).SendKeys("Senior QA Lead");
                
                BasePage.driver.FindElement(By.Id("addCandidate_keyWords")).SendKeys(",,,,");
                BasePage.driver.FindElement(By.Id("addCandidate_comment")).SendKeys("Done");
                BasePage.driver.FindElement(By.Id("addCandidate_appliedDate")).Click();
                BasePage.driver.FindElement(By.Id("addCandidate_appliedDate")).SendKeys("2022-06-25");
                BasePage.driver.FindElement(By.Id("addCandidate_consentToKeepData")).Click();
                BasePage.driver.FindElement(By.Id("btnSave")).Click();
            }
        }

        public class organization
        {
            public void Information()
            {
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Organization")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_viewOrganizationGeneralInformation")).Click();

                BasePage.driver.FindElement(By.Id("btnSaveGenInfo")).Click();

                BasePage.driver.FindElement(By.Id("btnSaveGenInfo")).Click();
            }

        }

        public class Skills
        {
            public void addSkills()
            {
                BasePage.driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_Qualifications")).Click();
                BasePage.driver.FindElement(By.Id("menu_admin_viewSkills")).Click();
                BasePage.driver.FindElement(By.Id("btnAdd")).Click();

                BasePage.driver.FindElement(By.Id("skill_name")).SendKeys("C Programming");
                BasePage.driver.FindElement(By.Id("skill_description")).SendKeys("Programming Lanuguage");
            }
        }
    }
}
