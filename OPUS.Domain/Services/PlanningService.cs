using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
    public class PlanningService: IPlanningService
    {

        public readonly IUnitOfWork _unitOfWork;
        public PlanningService(IUnitOfWork unitofWork)
        {
            this._unitOfWork = unitofWork;
        }
        public List<Feasibility> GetAll()
        {
            return _unitOfWork.FeasibilityRepository.GetAll();
        }

        public List<Feasibility> PageAll(int skip, int take)
        {
            return _unitOfWork.FeasibilityRepository.PageAll(skip, take);
        }

        public Feasibility FindFeasibilityById(int FeasibilityId)
        {
            return _unitOfWork.FeasibilityRepository.FindById(FeasibilityId);
        }

        public string Add(Feasibility _feasibility)
        {
            return "";
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

        public List<Client> getAllClient()
        {
            return _unitOfWork.ClientRepository.GetAll();
        }

        public Client FindClientById(int cid)
        {
            return _unitOfWork.ClientRepository.FindClientById(cid);
        }

        public bool AddRemarks(List<ProcessRemark> ListofProcessRemarks)
        {
            try
            {
                _unitOfWork.ProcessRemarkRepository.AddProcessRemarks(ListofProcessRemarks);
                _unitOfWork.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void AddFinalPlan(FinalPlan _finalPlan)
        {
            try
            {
                _unitOfWork.FinalPlanRepository.Add(_finalPlan);
                _unitOfWork.SaveChanges();
               
            }
            catch (Exception ex)
            {
               
            }
        }

        public List<ProcessRemark> getAllPossibleNotPossibleRemarks()
        {
            return _unitOfWork.ProcessRemarkRepository.GetAll(); ;
        }

        public List<Feasibility> FindAllFeasibilityForPlanningSLA()
        {
            return _unitOfWork.FeasibilityRepository.FindAllFeasibilityForPlanningSLA(); ;
        }
    }
}
