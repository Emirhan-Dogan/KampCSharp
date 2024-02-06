using Business.Abstaract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager<T> : ISupplierService<T>
    where T : class, IApplicant, new()
{
    private IApplicantService<T> _applicantService;

    public PttManager(IApplicantService<T> applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(T applicant)
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
