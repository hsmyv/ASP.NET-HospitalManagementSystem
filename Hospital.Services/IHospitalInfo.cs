using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Utilites;
using Hospital.ViewModels;

namespace Hospital.Services
{
    public interface IHospitalInfo
    {
        PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize);
    }
}
