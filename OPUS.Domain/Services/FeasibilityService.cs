using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
    public class FeasibilityService : IFeasibilityService
    {
        public readonly IUnitOfWork _unitOfWork;
        public FeasibilityService(IUnitOfWork unitofWork)
        {
            this._unitOfWork = unitofWork;
        }

        public string Add(Feasibility _feasibility)
        {
            if (_feasibility == null)
                throw new ArgumentNullException("_feasibility");

            try
            {
               _unitOfWork.FeasibilityRepository.Add(_feasibility);
              return _unitOfWork.SaveChanges().ToString();
               
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string SetSLA(AssignedSLA _sla)
        {
            if (_sla == null)
                throw new ArgumentNullException("_sla");

            try
            {
                _unitOfWork.AssignedSLARepository.Add(_sla);
                return _unitOfWork.SaveChanges().ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }


        public Client FindClientByName(string clientname)
        {
            return null;
        }

        public Client FindClientById(int ClientId)
        {
            return _unitOfWork.ClientRepository.FindClientById(ClientId);
        }

        public string Delete(Feasibility _feasibility)
        {
            return "";
        }

        public void Update(Feasibility _feasibility)
        {
            _unitOfWork.FeasibilityRepository.Update(_feasibility);
            _unitOfWork.SaveChanges();
        }

        public List<Feasibility> GetAll()
        {
            return _unitOfWork.FeasibilityRepository.GetAll();
        }

        public List<Feasibility> PageAll(int skip, int take)
        {
            return _unitOfWork.FeasibilityRepository.PageAll(skip, take);
        }

        public List<Client> getAllClient()
        {
            return _unitOfWork.ClientRepository.GetAll();
        }

        public Feasibility FindFeasibilityById(int FeasibilityId)
        {
            return _unitOfWork.FeasibilityRepository.FindById(FeasibilityId);
        }

        public List<ProcessRemark> getAllPossibleNotPossibleRemarks()
        {
            return _unitOfWork.ProcessRemarkRepository.GetAll(); 
           
        }
        public List<CancelReason> getAllCancelReasons()
        {
            return _unitOfWork.CancelReasonRepository.GetAll();
        }
        public string AddWorkOrder(WorkOrder _workorder)
        {
            if (_workorder == null)
                throw new ArgumentNullException("_workorder");

            try
            {
                _unitOfWork.WorkOrderRepository.Add(_workorder);
                return _unitOfWork.SaveChanges().ToString();
            }
            catch (Exception ex)
            {
                return "";
            }



        }

        public bool AddWorkOrderDetail(List<WorkOrderDetail> wodetail)
        {
            try
            {
                _unitOfWork.WorkOrderDetailRepository.AddWorkOrderDetail(wodetail);
                _unitOfWork.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
