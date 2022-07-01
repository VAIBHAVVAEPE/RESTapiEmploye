using RESTapiEmploye.Entities;
using RESTapiEmploye.Model;
using System.Collections.Generic;
using System.Linq;

namespace RESTapiEmploye.Repositories
{
    public class EmployeRepositories : IEmployeRepositories
    {
        RepositoriesContext _context;
        public EmployeRepositories(RepositoriesContext context)
        {
            _context = context;
        }
        public int AddEmploye(Employe emp)
        {
            _context.Employe.Add(emp);
            int res = _context.SaveChanges();
            return res;
        }

        public int DeleteEmploye(int id)
        {
            var emp = _context.Employe.Where(x => x.Id == id).SingleOrDefault();
            if(emp !=null)
            {
                _context.Employe.Remove(emp);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0; 
            }
        }

        public IEnumerable<Employe> GetAllEmploye()
        {
            return _context.Employe.ToList();
        }

        public Employe GetEmployeById(int id)
        {
            var emp = _context.Employe.Where(x => x.Id == id).SingleOrDefault();
            return emp;
        }

        public int ModifyEmploye(Employe emp)
        {
            var em = _context.Employe.Where(x => x.Id == emp.Id).SingleOrDefault();
            if (em != null)
            {
                em.Name = emp.Name;
                em.Salary = emp.Salary;
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
