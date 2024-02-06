using Business.Abstaract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(IApplicant applicant)
    {   
        if (_applicantService.CheckPerson(applicant))
        {
            Console.WriteLine("Maske Verildi: " + applicant.FirstName);
        }
        else
        {
            Console.WriteLine("Maske verilemedi");
        }
    }
}
