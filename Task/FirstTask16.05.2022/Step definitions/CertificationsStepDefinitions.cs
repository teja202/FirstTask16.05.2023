using FirstTask.Pages;
using FirstTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace FirstTask
{
    [Binding]
    public class CertificationsStepDefinitions : CommonDriver
    {

        Certifications CertObj = new Certifications();

        [When(@"I add Certficate, Certificatefrom and Year")]
        public void WhenIAddCertficateCertificatefromAndYear()
        {
            CertObj.CertificationSteps(Driver);
        }

        [Then(@"Certificate record should be successfully added on profile page")]
        public void ThenCertificateRecordShouldBeSuccessfullyAddedOnProfilePage()
        {
            CertObj.ValidateCertification(Driver);
        }

        [When(@"I  update Certificate,Certificate from and the Year")]
        public void WhenIUpdateCertificateCertificateFromAndTheYear()
        {
            CertObj.UpdateCertificate(Driver);
        }

        [Then(@"Certification record should be updated and displayed on profile page")]
        public void ThenCertificationRecordShouldBeUpdatedAndDisplayedOnProfilePage()
        {
            CertObj.ValidateUpdatedCertification(Driver);
        }

        [When(@"I  delete an existing certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            CertObj.DeleteCertificate(Driver);
        }

        [Then(@"The record should be  deleted and should NOT be displayed in the list")]
        public void ThenTheRecordShouldBeDeletedAndShouldNOTBeDisplayedInTheList()
        {
            CertObj.GetDeleteCertificate(Driver);
        }

    }
}