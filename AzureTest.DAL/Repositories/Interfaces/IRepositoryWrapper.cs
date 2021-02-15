using System.Threading.Tasks;

namespace VetClinic.DAL.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAnimalRepository AnimalRepository { get; }
        IAnimalTypeRepository AnimalTypeRepository { get; }
        IAppointmentProceduresRepository AppointmentProceduresRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        IClientRepository ClientRepository { get; }
        IDoctorRepository DoctorRepository { get; }
        IPositionRepository PositionRepository { get; }
        IProcedureRepository ProcedureRepository { get; }
        IServiceRepository ServiceRepository { get; }
        IStatusRepository StatusRepository { get; }
        IPostRepository PostRepository { get; }
        Task SaveAsync();
    }
}