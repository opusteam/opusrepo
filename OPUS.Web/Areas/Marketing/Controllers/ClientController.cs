using OPUS.Domain;
using OPUS.Domain.Entities.Process;
using OPUS.Domain.Services;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.Marketing.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        // GET: Marketing/Client
        private const int defaultPageSize = 2;
        private readonly IClientService _clientService;
        //private readonly IClientContactDetailService _clientcontactService;
        public ClientController(IClientService clientService)
        {
            this._clientService = clientService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewClient()
        {
            List<BusinessType> _type = new List<BusinessType>();

            List<SelectListItem> BusinessTypes = new List<SelectListItem>();

            _type.Add(new BusinessType { Id = 1, Name = "ISP" });
            _type.Add(new BusinessType { Id = 2, Name = "ICS" });
            _type.Add(new BusinessType { Id = 3, Name = "IGW" });
            _type.Add(new BusinessType { Id = 4, Name = "Gateway" });

            foreach (var _btype in _type)
            {
                BusinessTypes.Add(new SelectListItem() { Text = _btype.Name, Value = _btype.Id.ToString() });
            }


            this.ViewBag.BusinessTypeList = BusinessTypes;

            return View();
        }


        [AllowAnonymous]
        [HttpPost]
       public ActionResult NewClient(ClientViewModel cvm)
        {
            return View();
        }

        [AllowAnonymous]
        public JsonResult CreateClient(Client clientobj)
        {
            if (ModelState.IsValid)
            {
                Client c1 = new Client();
                c1.Name = clientobj.Name;
                c1.ShortName = clientobj.ShortName;
                c1.RegDate = DateTime.Now;
                c1.OfficeAddress = clientobj.OfficeAddress;
                c1.Phone = clientobj.Phone;
                c1.Fax = clientobj.Fax;
                c1.Email = clientobj.Email;
                c1.WebSite = clientobj.WebSite;
                c1.City = clientobj.City;
                c1.Region = clientobj.Region;
                c1.PostalCode = clientobj.PostalCode;
                c1.BillingDepartment = clientobj.BillingDepartment;
                c1.Note = clientobj.Note;
                c1.KamId = User.Identity.Name;
                c1.CreatedBy = User.Identity.Name;
                c1.BusinessTypeId = clientobj.BusinessTypeId;
                c1.VatNo = clientobj.VatNo;
                c1.ModifiedDate = DateTime.Now;

                _clientService.Add(c1);
                var id = c1.Id;

                List<ContactDetail> _contactdetail = new List<ContactDetail>();
                foreach (var conatct in clientobj.ContactDetails.ToList())
                {
                    ContactDetail _contact = new ContactDetail();
                    _contact.ClientId = id;
                    _contact.Name = conatct.Name;
                    _contact.Designation = conatct.Designation;
                    _contact.Address = conatct.Address;
                    _contact.Email = conatct.Email;
                    _contact.Phone = conatct.Phone;
                    _contact.Fax = conatct.Fax;
                    _contactdetail.Add(_contact);


                }

                if (_contactdetail != null)
                {
                    _clientService.AddClientContacDetail(_contactdetail);
                }

                return Json("Successfully saved", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Something went wrong!", JsonRequestBehavior.AllowGet);
            }
           
        }

        public ActionResult GetAllClient()
        {
            List<Client> _clientList = _clientService.GetAll();
            return View(_clientList);
        }

        public ActionResult GetAllClientByPaging(int? page)
        {
            int currentPageIndex = page.HasValue ? page.Value : 1;
            List<Client> _clientList = _clientService.GetAll();// PagingList(2,2);
            return View(_clientList.ToPagedList(currentPageIndex,defaultPageSize));
        }

    }
}