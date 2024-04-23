using MVC_ClinicSystem1712.Models;

namespace MVC_ClinicSystem1712.Services
{
    public interface IPatientService
    {
        void Insert(PatientDTO patientDTO);

        List<PatientDTO> GetByName(string Name);

        PatientDTO Load(int Id);

        void Update(PatientDTO patientDTO);

        List<PatientDTO> GetAll();
    }
}
