using RESTapiEmploye.Model;
using System.Collections.Generic;

namespace RESTapiEmploye.Services
{
    public interface IEmployeServices
    {
         IEnumerable<Employe> GetAllEmploye();
        Employe GetEmployeById(int id);
        int AddEmploye(Employe emp);
        int ModifyEmploye(Employe emp);
        int DeleteEmploye(int id);
        object GetEmployeById();
    }
}
