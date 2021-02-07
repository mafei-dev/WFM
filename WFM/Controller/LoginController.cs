using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFM.Database;
using WFM.Entity;
using WFM.Repository;

namespace WFM.Controller
{
    class LoginController
    {
        private IAdminRepository adminRepository;
        public bool CheckUsernamePassword(Admin admin)
        {


            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();

                try
                {
                    adminRepository = new AdminRepository(unitOfWork);
                    int res= adminRepository.CheckUsernamePassword(admin);
                    Console.WriteLine("res >>> {0}", res);
                    unitOfWork.Commit();
                    return res == 1;
                }
                catch 
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }



        }
    }
}
