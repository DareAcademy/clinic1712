using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MVC_ClinicSystem1712.data;
using MVC_ClinicSystem1712.Models;
using System.Xml.Linq;

namespace MVC_ClinicSystem1712.Services
{
    public class PatientService: IPatientService
    {
        ClinicContext context ;
        IMapper mapper;
        public PatientService(ClinicContext _context,IMapper _mapper)
        {
            mapper = _mapper;
            context = _context;
            //context = new ClinicContext();
        }
        public void Insert(PatientDTO patientDTO)
        {
            //Patient newPatient = new Patient();
            //newPatient.FirstName = patientDTO.FirstName;
            //newPatient.LastName = patientDTO.LastName;
            //newPatient.Gender = patientDTO.Gender;
            //newPatient.Phone = patientDTO.Phone;
            //newPatient.Email = patientDTO.Email;
            //newPatient.Country_Id = patientDTO.Country_Id;
            //newPatient.ProfileName = patientDTO.ProfileName;

            Patient newPatient = mapper.Map<Patient>(patientDTO);
            context.patients.Add(newPatient);
            context.SaveChanges();
        }

        public void Update(PatientDTO patientDTO)
        {
            Patient patient = mapper.Map<Patient>(patientDTO);
            context.patients.Attach(patient);
            context.Entry(patient).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<PatientDTO> GetByName(string Name)
        {
            //List<Patient> allPatients = (from pat in context.patients
            //                             where pat.FirstName == fName
            //                             select pat).ToList();

            //List<Patient> allPatients = context.patients.Include("country").Where(p => p.FirstName == fName).ToList();

            List<Patient> allPatients = context.patients.Where(p => p.FirstName.Contains (Name) || p.LastName.Contains(Name)).ToList();
            List<PatientDTO> patients = mapper.Map<List<PatientDTO>>(allPatients);

            //List <PatientDTO> patients = new List<PatientDTO>();
            //foreach (Patient pat in allPatients)
            //{
            //    PatientDTO patDTO = new PatientDTO();
            //    patDTO.Country_Id = pat.Country_Id;
            //    patDTO.FirstName = pat.FirstName;
            //    patDTO.LastName = pat.LastName;
            //    patDTO.Phone = pat.Phone;
            //    patDTO.Gender = pat.Gender;
            //    patDTO.Email = pat.Email;
            //    patDTO.Id = pat.Id;
            //    patDTO.ProfileName = pat.ProfileName;
            //    patients.Add(patDTO);
            //}

            return patients;
        }


        public List<PatientDTO> GetAll()
        {
            List<Patient> allPatients = context.patients.ToList();
            List<PatientDTO> patients = mapper.Map<List<PatientDTO>>(allPatients);

            return patients;
        }

        public PatientDTO Load(int Id)
        {
            Patient patient = context.patients.Find(Id);

            PatientDTO patientDTO = mapper.Map<PatientDTO>(patient);

            return patientDTO;
        }
    }
}
