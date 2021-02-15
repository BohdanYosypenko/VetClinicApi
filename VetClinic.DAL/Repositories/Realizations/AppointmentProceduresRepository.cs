using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class AppointmentProceduresRepository : RepositoryBase<AppointmentProcedures>, IAppointmentProceduresRepository
    {
        public AppointmentProceduresRepository(ApplicationContext context) : base(context) { }
    }
}