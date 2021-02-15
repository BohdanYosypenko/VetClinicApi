using System.Threading.Tasks;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationContext _context;
        private IAnimalRepository _animalRepository;
        private IAnimalTypeRepository _animalTypeRepository;
        private IAppointmentProceduresRepository _appointmentProceduresRepository;
        private IAppointmentRepository _appointmentRepository;
        private IClientRepository _clientRepository;
        private IDoctorRepository _doctorRepository;
        private IPositionRepository _positionRepository;
        private IProcedureRepository _procedureRepository;
        private IServiceRepository _serviceRepository;
        private IStatusRepository _statusRepository;
        private IPostRepository _postRepository;

        public RepositoryWrapper(ApplicationContext context)
        {
            _context = context;
        }


        public IAnimalRepository AnimalRepository
        {
            get { return _animalRepository ??= new AnimalRepository(_context); }
        }

        public IAnimalTypeRepository AnimalTypeRepository
        {
            get { return _animalTypeRepository ??= new AnimalTypeRepository(_context); }
        }

        public IAppointmentProceduresRepository AppointmentProceduresRepository
        {
            get { return _appointmentProceduresRepository ??= new AppointmentProceduresRepository(_context); }
        }

        public IAppointmentRepository AppointmentRepository
        {
            get { return _appointmentRepository ??= new AppointmentRepository(_context); }
        }

        public IClientRepository ClientRepository
        {
            get { return _clientRepository ??= new ClientRepository(_context); }
        }

        public IDoctorRepository DoctorRepository
        {
            get { return _doctorRepository ??= new DoctorRepository(_context); }
        }

        public IPositionRepository PositionRepository
        {
            get { return _positionRepository ??= new PositionRepository(_context); }
        }

        public IProcedureRepository ProcedureRepository
        {
            get { return _procedureRepository ??= new ProcedureRepository(_context); }
        }

        public IServiceRepository ServiceRepository
        {
            get { return _serviceRepository ??= new ServiceRepository(_context); }
        }

        public IStatusRepository StatusRepository
        {
            get { return _statusRepository ??= new StatusRepository(_context); }
        }

        public IPostRepository PostRepository
        {
            get { return _postRepository ??= new PostRepository(_context); }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}