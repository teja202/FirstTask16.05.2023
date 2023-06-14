using FirstTask.Pages;
using FirstTask.Utilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace FirstTask
{
    [Binding]
    public class CertificationsStepDefinitions : Commondriver
    {

        Certifications CertObj = new Certifications();
        LoginPage LoginPageObj = new LoginPage();
       

        [Given(@"I logged into Mars application successfully")]
        public void GivenILoggedIntoMarsApplicationSuccessfully()
        {
           
            LoginPageObj.LoginSteps(driver);
        }


        [When(@"I add Certficate, Certificatefrom and Year")]
        public void WhenIAddCertficateCertificatefromAndYear()
        {
            CertObj.CertificationSteps(driver);
        }

        [Then(@"Certificate record should be successfully added on profile page")]
        public void ThenCertificateRecordShouldBeSuccessfullyAddedOnProfilePage()
        {
            CertObj.ValidateCertification(driver);
        }

        [When(@"I  update Certificate,Certificate from and the Year")]
        public void WhenIUpdateCertificateCertificateFromAndTheYear()
        {
            CertObj.UpdateCertificate(driver);
        }

        [Then(@"Certification record should be updated and displayed on profile page")]
        public void ThenCertificationRecordShouldBeUpdatedAndDisplayedOnProfilePage()
        {
            CertObj.ValidateUpdatedCertification(driver);
        }

        [When(@"I  delete an existing certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            CertObj.DeleteCertificate(driver);
        }

        [Then(@"The record should be  deleted and should NOT be displayed in the list")]
        public void ThenTheRecordShouldBeDeletedAndShouldNOTBeDisplayedInTheList()
        {
            CertObj.GetDeleteCertificate(driver);
        }

    }
}