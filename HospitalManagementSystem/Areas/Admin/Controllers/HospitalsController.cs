using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Areas.Admin.Controllers
{
    public class HospitalsController : Controller
    {
        private IHospitalInfo _hospitalInfo;

        public HospitalsController(IHospitalInfo hospitalInfo)
        {
            _hospitalInfo = hospitalInfo;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize= 10)
        {
            return View(_hospitalInfo.GetAll(pageNumber, pageSize));
        }
    }
}
