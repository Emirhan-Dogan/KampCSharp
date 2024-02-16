using Business.Abstaract;
using Entities.Abstract;
using Entities.Concrete;
using MernisForeignServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ForeignerManager : IApplicantService<Foreign>
{
    public void ApplyForMask(Foreign applicant)
    {

    }

    public bool CheckPerson(Foreign applicant)
    {
        KPSPublicYabanciDogrulaSoapClient client = new KPSPublicYabanciDogrulaSoapClient(
            KPSPublicYabanciDogrulaSoapClient.EndpointConfiguration.KPSPublicYabanciDogrulaSoap);

        return client.YabanciKimlikNoDogrulaAsync(
            new YabanciKimlikNoDogrulaRequest(
                new YabanciKimlikNoDogrulaRequestBody(
                    applicant.NationalIdentity,
                    applicant.FirstName,
                    applicant.LastName,
                    applicant.DateOfBirth.Day,
                    applicant.DateOfBirth.Month,
                    applicant.DateOfBirth.Year)))
            .Result.Body.YabanciKimlikNoDogrulaResult;
    }

    public List<Foreign> GetList()
    {
        return null;
    }
}
