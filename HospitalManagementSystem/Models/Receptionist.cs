using HospitalManagementSystem.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Receptionist
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual Hospital Hospital { get; set; }

        public void ValidatePatient(Patient patient,Doctor doctor,DateTime timeOfAppointment)
        {
            if(patient is RegisteredPatient)
            {
                if(patient.Appointment is null)
                {
                   var appointment = patient.BookAppointment(Hospital, doctor, timeOfAppointment);
                    IDataStore<Appointment>.Create(appointment);
                    doctor.Appointments.Enqueue(appointment);
                    Console.WriteLine($"You've just booked an appointment with {doctor.FullName}");
                    Console.WriteLine("Please wait your turn in the lobby");
                }
                else
                {
                    doctor.Appointments.Enqueue(patient.Appointment);
                    Console.WriteLine("Please wait your turn in the lobby");
                }

            }
            else
            {
                var appointment = patient.BookAppointment(Hospital, doctor, timeOfAppointment);
                IDataStore<Appointment>.Create(appointment);
                doctor.Appointments.Enqueue(appointment);
                Console.WriteLine($"You've just booked an appointment with {doctor.FullName}");
                Console.WriteLine("Please wait your turn in the lobby");
            }
        }

    }
}
