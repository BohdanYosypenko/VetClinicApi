using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IDoctorService
    {
        public Task<Doctor> GetDoctorByIdAsync(int doctorId);
        public Task<ICollection<Doctor>> GetDoctorAsync(
            DoctorsFilter filter = null,
            PaginationFilter pagination = null);
        public Task<Doctor> AddDoctorAsync(Doctor doctor, User user);
        public Task<bool> RemoveDoctorAsync(int doctorId);
        public Task<bool> UpdateDoctorAsync(Doctor inputDoctor, User inputUser, int doctorId);
        public Task<int> GetTotalCount(DoctorsFilter filter = null);
        public Task<bool> IsAnyDoctorAsync(int id);
        public  Task<IEnumerable<string>> GetAllDoctorsEmails();
    }
}
