using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mateusz_Cebrat_PUM
{
    class Database_service
    {
        public void patientsSave(string name, string surname, string pesel, string sex, string birth,string adress, string city, int id)
        {
            using(Kartoteka_Entities1 context = new Kartoteka_Entities1())
            {
                var newDoctor = context.Doctors.FirstOrDefault(x => x.doctorID == id);

                Patients patient = new Patients
                {
                    name = name,
                    surname = surname,
                    pesel = pesel,
                    sex = sex,
                    dateOfBirth = birth,
                    adress = adress,
                    Doctors = newDoctor,
                    city = city
                };
                context.Patients.Add(patient);
                context.SaveChanges();
                var idn = context.Patients.Where(x => x.pesel == pesel).FirstOrDefault();
                MessageBox.Show("Id pacjenta: " + idn.patientID.ToString());     
            }
        }

        public void anamnesisSave(string weight, string height, string treatment, string information, string diseases, string alergy, string medicine, string group, string rh, string alcohol, string cigarets,int id)
        {
            using (Kartoteka_Entities1 context = new Kartoteka_Entities1())
            {
                var newPatient = context.Patients.FirstOrDefault(x => x.patientID == id);
                Anamnesis first = new Anamnesis
                {
                    patientID = newPatient.patientID,
                    weight = Convert.ToDecimal(weight),
                    height = Convert.ToInt32(height),
                    treatment = treatment,
                    additionalInformation = information,
                    chronicDiseases = diseases,
                    allergy = alergy,
                    medicines = medicine,
                    bloodType = group,
                    rh = rh,
                    alcohol =alcohol,
                    cigaretts=cigarets

                };
                context.Anamnesis.Add(first);
                context.SaveChanges();
            }
        }

        public void WorkIntervievSave(string profession, string practiced,string disease,string niuisance, string accidents, int ID)
        {
            using (Kartoteka_Entities1 context = new Kartoteka_Entities1())
            {
                var newPatient = context.Patients.FirstOrDefault(x => x.patientID == ID);

                WorkInterview work = new WorkInterview
                {
                    patientID = newPatient.patientID,
                    profession = profession,
                    practisedProfession = practiced,
                    ocupationalDisease = disease,
                    nuisance = niuisance,
                    accidents = accidents
                };

                context.WorkInterview.Add(work);
                context.SaveChanges();

                
            }
        }

        public void VisitsSave(string date,string time, string pressure, string pulse,string temperature,string symptoms,string diagnosis,string recommedations, string medicines,string information, int pID, int dID)
        {
            using (Kartoteka_Entities1 context = new Kartoteka_Entities1())
            {
                var newPatient = context.Patients.FirstOrDefault(x => x.patientID == pID);
                var newDoctor = context.Doctors.FirstOrDefault(x => x.doctorID == dID);

                Visits visit = new Visits
                {

                    patientID = newPatient.patientID,
                    doctorID = newDoctor.doctorID,
                    date = date,
                    time = time,
                    pressure = pressure,
                    pulse = Convert.ToInt16(pulse),
                    temperature = Convert.ToDecimal(temperature),
                    symptoms = symptoms,
                    diagnosis = diagnosis,
                    recommendations = recommedations,
                    visitMedicines = medicines,
                    additionalVisitInformation = information,
                    mark = 1
                };
                context.Visits.Add(visit);
                context.SaveChanges();

                
            }
        }
    }
}
