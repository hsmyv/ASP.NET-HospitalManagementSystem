using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models;
using Hospital.Repositories.Interfaces;
using Hospital.Utilites;
using Hospital.ViewModels;

namespace Hospital.Services
{
    public class HospitalInfoService : IHospitalInfo
    {
        private IUnitOfWork _unitOfWork;

        public HospitalInfoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize)
        {
            var HospitalInfoViewModel = new HospitalInfoViewModel();
        }
    }
}
