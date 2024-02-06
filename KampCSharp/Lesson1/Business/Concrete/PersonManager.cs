using Business.Abstaract;
using Entities.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{ 
    public void ApplyForMask(IApplicant applicant)
    {

    }

    public List<IApplicant> GetList()
    {
        return null;
    }

    public bool CheckPerson(IApplicant applicant)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(applicant.NationalIdentity, applicant.FirstName, applicant.LastName, applicant.DateOfBirth.Year)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }

}
