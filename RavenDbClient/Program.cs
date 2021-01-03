using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDCard.Data.IdCardEFModel;
using Newtonsoft.Json;
using Raven.Client.Documents.Commands;
using Raven.Client.Documents.Conventions;
using RavenDbClient.Model;

namespace RavenDbClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Main();
        }

        private void Main()
        {
            //Application app = new Application();

            //var rep = new Representative();

            //rep.DateOfBirth = 19910815;
            //rep.Name1 ="repName1";
            //rep.Name2 ="repName2";
            //rep.Sex = new PARAM() { Domain ="Sex", Label ="Male", ValueEng ="Sex", ValueArb ="Sex arb" };
            //rep.Statuses = new List<DLStatus> {  }

            var prams = new List<PARAM>()
            {
                new PARAM { Domain ="Sex",  ValueEng="Female", ValueArb ="إناثا", Label ="Female" },
                new PARAM { Domain ="Sex",  ValueEng="Male", ValueArb ="الذكر", Label ="Male"},
                new PARAM { Domain ="PaymentStatus", ValueEng ="Created", ValueArb ="Created Egypt", Label ="PendingPayment"},
                new PARAM { Domain ="PaymentStatus", ValueEng ="Paid", ValueArb ="Paid Egypt", Label ="Paid"},
                new PARAM { Domain ="DocumentType", ValueEng ="Certificate of marital", ValueArb ="Certificate of marital  EG", Label ="CertificateOfMarital"},
                new PARAM { Domain ="DocumentType", ValueEng ="Certificate of kinship", ValueArb ="Certificate of kinship EG", Label ="CertificateOfKinship"},
                new PARAM { Domain ="DocumentType", ValueEng ="Science degree", ValueArb ="Science degree  EG", Label ="ScienceDegreeDoc"},
                new PARAM { Domain ="DocumentType", ValueEng ="Commercial registration", ValueArb ="Commercial registration EG", Label ="CommercialRegDoc"},
                new PARAM { Domain ="MaritalStatus", ValueEng ="Single", ValueArb ="Single EG", Label ="Single"},
                new PARAM { Domain ="MaritalStatus", ValueEng ="Married", ValueArb ="Married ARB", Label ="Married"},
                new PARAM { Domain ="MaritalStatus", ValueEng ="Divorced", ValueArb ="Divorced ARB", Label ="Divorced"},
                new PARAM { Domain ="MaritalStatus", ValueEng ="Widowed", ValueArb ="Widowed ARB", Label ="Widowed"},
                new PARAM { Domain ="DocumentType", ValueEng ="Certificate of residence", ValueArb ="Certificate of residence EG", Label ="CertificateOfResidence"},
                new PARAM { Domain ="Urgency", ValueEng ="Normal", ValueArb ="Normal arb", Label ="Normal"},
                new PARAM { Domain ="Urgency", ValueEng ="Urgent", ValueArb ="Urgent arb", Label ="Urgent"},
                new PARAM { Domain ="ApplicationStatuses", ValueEng ="Created", ValueArb ="Created arb", Label ="Created"},
                new PARAM { Domain ="ApplicationStatuses", ValueEng ="Ready to send for identification", ValueArb ="Ready to send for identification arb", Label ="IdentSendReady"},
                new PARAM { Domain ="ApplicationStatuses", ValueEng ="Sent for identification", ValueArb ="Sent for identification arb", Label ="IdentSent"},
                new PARAM { Domain ="ApplicationStatuses", ValueEng ="Identification completed", ValueArb ="Identification completed arb", Label ="IdentCompleted"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Identification ambiguous", ValueArb ="Identification ambiguous arb", Label ="IdentAmbiguous"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Identification error", ValueArb ="Identification error arb", Label ="IdentError"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Ready to send for personalization", ValueArb ="Ready to send for personalization arb", Label ="PersSendReady"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Sent for personalization", ValueArb ="Sent for personalization arb", Label ="PersSent"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Personalization completed", ValueArb ="Personalization Completed arb", Label ="PersCompleted"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Personalization error", ValueArb ="Personalization error arb", Label ="PersError"},
                new PARAM { Domain ="Reason",  ValueEng="Primary registration", ValueArb ="Primary registration arb", Label ="PrimaryRegistration"},
                new PARAM { Domain ="Reason",  ValueEng="Expiration date", ValueArb ="Expiration date arb", Label ="ExpirationDate"},
                new PARAM { Domain ="Reason",  ValueEng="Data change", ValueArb ="Data change arb", Label ="DataChange"},
                new PARAM { Domain ="Reason",  ValueEng="Lost", ValueArb ="Lost arb", Label ="Lost"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Created", ValueArb ="Created EG", Label ="Created"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Verified", ValueArb ="Verified EG", Label ="Verified"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Issued", ValueArb ="Issued EG", Label ="Issued"},
                new PARAM { Domain ="IdCardAction",  ValueEng="Withdraw now", ValueArb ="Withdraw now EG", Label ="WithdrawNow"},
                new PARAM { Domain ="IdCardAction",  ValueEng="Withdraw when issuing", ValueArb ="Withdraw when issuing EG", Label ="WithdrawWhenIssuing"},
                new PARAM { Domain ="IdCardAction",  ValueEng="Leave", ValueArb ="Leave EG", Label ="Leave"},
                new PARAM { Domain ="IdCardAction",  ValueEng="Withdrawal impossible", ValueArb ="Withdrawal impossible EG", Label ="WithdrawalImpossible"},
                new PARAM { Domain ="DocumentType",  ValueEng="Statement of loss", ValueArb ="Statement of loss EG", Label ="StatementOfLoss"},
                new PARAM { Domain ="DocumentType",  ValueEng="Reason for data change document", ValueArb ="Reason for data change document EG", Label ="ReasonForDataChangeDoc"},
                new PARAM { Domain ="Reason",  ValueEng="Stolen", ValueArb ="Stolen arb EG", Label ="Stolen"},
                new PARAM { Domain ="IdCardSeries",  ValueEng="BB", ValueArb ="BB", Label ="BB"},
                new PARAM { Domain ="IdCardLastNumber",  ValueEng="1", ValueArb ="1", Label ="45"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Ready for personalization", ValueArb ="Ready for personalization arb", Label ="ReadyToPers"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Identification found no matches", ValueArb ="Identification found no matches arb", Label ="IdentNoMatches"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Liable for service, didn't served", ValueArb ="Liable for service, didn't served arb", Label ="vpv_not_served"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Liable for service, served", ValueArb ="Liable for service, served arb", Label ="vpv_served"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Liable for service, delayed", ValueArb ="Liable for service, delayed arb", Label ="vpv_delay"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Liable for service, temporarily released", ValueArb ="Liable for service, temporarily released arb", Label ="vpv_temp_rel"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Applicant liable for service, permanently released", ValueArb ="Applicant liable for service, permanently released arb", Label ="zpv_perm_rel"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Applicant not liable for service", ValueArb ="Applicant not liable for service arb", Label ="z_not_liable"},
                new PARAM { Domain ="DocumentType",  ValueEng="Military duty document", ValueArb ="Military duty document arb", Label ="MilitaryDutyDocument"},
                new PARAM { Domain ="MilitaryServiceType",  ValueEng="Armed forces", ValueArb ="Armed forces arb", Label ="ArmedForces"},
                new PARAM { Domain ="MilitaryServiceType",  ValueEng="Police", ValueArb ="Police arb", Label ="Police"},
                new PARAM { Domain ="MilitaryDutyStatus",  ValueEng="Currently at service", ValueArb ="Currently at service arb", Label ="CurrentlyAtService"},
                new PARAM { Domain ="VotingPlace",  ValueEng="Place of birth", ValueArb ="Place of birth arb", Label ="PlaceOfBirth"},
                new PARAM { Domain ="VotingPlace",  ValueEng="Place of living", ValueArb ="Place of living arb", Label ="PlaceOfLiving"},
                new PARAM { Domain ="VotingPlac",  ValueEng="Place of working", ValueArb ="Place of working arb", Label ="PlaceOfWorking"},
                new PARAM { Domain ="VotingPlace",  ValueEng="Other", ValueArb ="Other arb", Label ="Other"},
                new PARAM { Domain ="AddressDefaultCountryId",  ValueEng="292", ValueArb ="292", Label ="292"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Withdrawn", ValueArb ="Withdrawn EG", Label ="Withdrawn"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Registred in system", ValueArb ="Registred in system arb", Label ="Registred"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Rejected", ValueArb ="Rejected arb", Label ="Rejected"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Registration cancelled", ValueArb ="Registration cancelled arb", Label ="CancelRegister"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Identification error during personalization", ValueArb ="Identification error during personalization arb", Label ="PersIdentError"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Ready to issue", ValueArb ="Ready to issue eg", Label ="ReadyToIssue"},
                new PARAM { Domain ="PaymentType",  ValueEng="Invoice Eng", ValueArb ="Invoice Arab", Label ="Invoice"},
                new PARAM { Domain ="PaymentType",  ValueEng="Terminal Eng", ValueArb ="Terminal Arab", Label ="Terminal"},
                new PARAM { Domain ="PaymentType",  ValueEng="Local Office Eng", ValueArb ="Local Office Arab", Label ="LocalOffice"},
                new PARAM { Domain ="MaritalStatus",  ValueEng="Undefined", ValueArb ="Undefined arb", Label ="Undefined"},
                new PARAM { Domain ="ApplicationStatuses",  ValueEng="Issued", ValueArb ="Issued arb", Label ="Issued"},
                new PARAM { Domain ="Reason",  ValueEng="Error in data", ValueArb ="Error in data arb", Label ="DataError"},
                new PARAM { Domain ="Reason",  ValueEng="Unsuitable for usage", ValueArb ="Unsuitable for usage arb", Label ="Unusable"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Not valid", ValueArb ="Not valid arb", Label ="NotValid"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Returned to state", ValueArb ="Returned to state arb", Label ="ReturnedToState"},
                new PARAM { Domain ="IdCardStatuses",  ValueEng="Destroyed", ValueArb ="Destroyed arb", Label ="Destroyed"}
            };


            var professions = new List<Profession>()
            {
                new Profession() { IsActual = 1, NameEng = "Gunner", NameArb = "Gunner", ShortName = "BRTTTTTT"  },
                new Profession() { IsActual = 1, NameEng = "Sniper", NameArb = "Sniper", ShortName = "BOOM HEADSHOT"  }

            };

            var storage = DocumentStoreHolder.Store;

            storage.Conventions.FindCollectionName = z => nameof(z);

            storage.Initialize();



            using (var session = storage.OpenSession("TestDb2"))
            {
                var p = session.Query<PARAM>().ToList();

                //    foreach (var item in professions)
                //    {
                //        session.Store(item);
                //    }

                //    foreach (var item in prams)
                //    {
                //        session.Store(item);
                //    }
                //    session.SaveChanges();
            }


            Console.ReadLine();


        }
    }
}
