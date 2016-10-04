using OPUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPUS.Domain.Services
{
    public class WorkOrderService : IWorkOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkOrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string Add(WorkOrder _workorder)
        {
            if (_workorder == null)
                throw new ArgumentNullException("_workorder");

            try
            {
                _unitOfWork.WorkOrderRepository.Add(_workorder);
                 return _unitOfWork.SaveChanges().ToString();
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                return false;
            }
        }

       

        public string Delete(WorkOrder _workorder)
        {
            if (_workorder == null)
                throw new ArgumentNullException("_workorder");


            _unitOfWork.WorkOrderRepository.Add(_workorder);
            return _unitOfWork.SaveChanges().ToString();


        }

        public void Update(WorkOrder _workorder)
        {
                       
        }

        public List<WorkOrder> GetAll()
        {
            
            return _unitOfWork.WorkOrderRepository.GetAll();
           
        }

        public List<Client> PagingList(int skip, int take)
        {
            return _unitOfWork.ClientRepository.PagingList(skip, take);
        }

    }
}