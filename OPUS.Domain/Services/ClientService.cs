using OPUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPUS.Domain.Services
{
    public class ClientService  : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string Add(Client _client)
        {
            if (_client == null)
                throw new ArgumentNullException("_client");

            try
            {
                _unitOfWork.ClientRepository.Add(_client);
                 return _unitOfWork.SaveChanges().ToString();
            }
            catch(Exception ex)
            {
                return "";
            } 
           

          
        }

        public bool AddClientContacDetail(List<ContactDetail> contactdetail)
        {
            try
            {
                _unitOfWork.ClientContactDetailRepository.AddClientContacDetail(contactdetail);
                _unitOfWork.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Client GetClientByName(string name)
        {
            return null;
        }

        public string Delete(Client _client)
        {
            if (_client == null)
                throw new ArgumentNullException("_client");


            _unitOfWork.ClientRepository.Add(_client);
            return _unitOfWork.SaveChanges().ToString();


        }

        public void Update(Client _client)
        {

            
        }

        public List<Client> GetAll()
        {
            
            return _unitOfWork.ClientRepository.GetAll();
           
        }

        public List<Client> PagingList(int skip, int take)
        {
            return _unitOfWork.ClientRepository.PagingList(skip, take);
        }

    }
}