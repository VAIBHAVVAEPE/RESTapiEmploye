using RESTapiEmploye.Model;
using RESTapiEmploye.Repositories;
using System.Collections.Generic;

namespace RESTapiEmploye.Services
{
    public class EmployeServices : IEmployeServices
    {
        readonly EmployeRepositories _repo;
        public EmployeServices(EmployeRepositories repo)
        {
            _repo = repo;
        }
        public int AddEmploye(Employe emp)
        {
            return _repo.AddEmploye(emp);
        }

        public int DeleteEmploye(int id)
        {
            return _repo.DeleteEmploye(id);
        }

        public IEnumerable<Employe> GetAllEmploye()
        {
            return _repo.GetAllEmploye();
        }

        public Employe GetEmployeById(int id)
        {
            return _repo.GetEmployeById(id);
        }

        public object GetEmployeById()
        {
            throw new System.NotImplementedException();
        }

        public int ModifyEmploye(Employe emp)
        {
            return _repo.ModifyEmploye(emp);
        }
    }
}
