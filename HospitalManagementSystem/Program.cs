// See https://aka.ms/new-console-template for more information

using HospitalManagementSystem;
using HospitalManagementSystem.DataStores;
using HospitalManagementSystem.Models;

FluentNHibernateHelper.OpenSession();

var hospital = new Hospital() { HospitalName = "John Hopkins" };
IDataStore<Hospital>.Create(hospital);

var drug1 = new Drug("Ativan", 30);
var drug2 = new Drug("Alprazolam", 20);
var drug3 = new Drug("Amlodipine", 15);
var drug4 = new Drug("Diazepam", 35);
var drug5 = new Drug("Acetaminophen", 10);
var drug6 = new Drug("Morphine", 50);
var drug7 = new Drug("Abilify", 32);
var drug8 = new Drug("Aldactone", 20);
var drug9 = new Drug("Lexapro", 11);
var drug10 = new Drug("Lisinopril", 5);
var drug11 = new Drug("Codeine", 18);

var drugs = new HashSet<Drug>() { drug1, drug2, drug3, drug4, drug5, drug5, drug6, drug7, drug8, drug9, drug10, drug11 };

foreach (var drug in drugs)
{
    IDataStore<Drug>.Create(drug);
}

var doctor1 = new Doctor() { FullName = "Dr Oluchi", Hospital = hospital };
var doctor2 = new Doctor() { FullName = "Dr Oge", Hospital = hospital };
var doctor3 = new Doctor() { FullName = "Dr Uche", Hospital = hospital };
var doctor4 = new Doctor() { FullName = "Dr Chiazor", Hospital = hospital };
var doctor5 = new Doctor() { FullName = "Dr Denny", Hospital = hospital };
var doctor6 = new Doctor() { FullName = "Dr Dan", Hospital = hospital };

var doctors = new HashSet<Doctor>() { doctor1, doctor2, doctor3, doctor4, doctor5, doctor6 };
foreach (var doctor in doctors)
{
    IDataStore<Doctor>.Create(doctor);
}

var nurse1 = new Nurse() { FullName = "Nurse Desmond", Hospital = hospital };
var nurse2 = new Nurse() { FullName = "Nurse Dammy", Hospital = hospital };
var nurse3 = new Nurse() { FullName = "Nurse Jude", Hospital = hospital };
var nurse4 = new Nurse() { FullName = "Nurse Felicia", Hospital = hospital };
var nurse5 = new Nurse() { FullName = "Nurse Sam", Hospital = hospital };

var nurses = new HashSet<Nurse>() { nurse1, nurse2, nurse3, nurse4, nurse5 };
foreach (var nurse in nurses)
{
    IDataStore<Nurse>.Create(nurse);
}

var pharmacist1 = new Pharmacist() { FullName = "Pharmacist Emmanuel", Hospital = hospital, AvailableDrugs = drugs };
var pharmacist2 = new Pharmacist() { FullName = "Pharmacist Adora", Hospital = hospital, AvailableDrugs = drugs };
var pharmacist3 = new Pharmacist() { FullName = "Pharmacist Betty", Hospital = hospital, AvailableDrugs = drugs };
var pharmacist4 = new Pharmacist() { FullName = "Pharmacist Jane", Hospital = hospital, AvailableDrugs = drugs };

var pharmacists = new HashSet<Pharmacist>() { pharmacist1, pharmacist2, pharmacist3, pharmacist4 };
foreach (var pharmacist in pharmacists)
{
    IDataStore<Pharmacist>.Create(pharmacist);
}

var receptionist = new Receptionist() { FullName = "Lovely Doe", Hospital = hospital };
IDataStore<Receptionist>.Create(receptionist);

var accountant = new Accountant() { FullName = "John Doe", Hospital = hospital };
IDataStore<Accountant>.Create(accountant);

var patient1 = new RegisteredPatient()
{
    Hospital = hospital,
    Gender = Gender.Male,
    PatientName = "Samuel",
    ContactNo = "+234577847297"
};
var patient2 = new RegisteredPatient()
{
    Hospital = hospital,
    Gender = Gender.Female,
    PatientName = "Daniel",
    ContactNo = "+234507834897"
}; var patient3 = new Patient()
{
    Gender = Gender.Male,
    PatientName = "Jonathan",
    ContactNo = "+2348705807297"
}; var patient4 = new RegisteredPatient()
{
    Hospital = hospital,
    Gender = Gender.Female,
    PatientName = "Joane",
    ContactNo = "+23457784248"
};
var patient5 = new Patient()
{
    Gender = Gender.Male,
    PatientName = "Joseph",
    ContactNo = "+142577847297"
}; 
var patient6 = new Patient()
{
    Gender = Gender.Male,
    PatientName = "Davvy",
    ContactNo = "+234577386497"
}; var patient7 = new RegisteredPatient()
{
    Hospital = hospital,
    Gender = Gender.Female,
    PatientName = "Gwenyfar",
    ContactNo = "+904577847297"
};
var patients = new HashSet<Patient>() { patient1, patient2, patient3, patient4, patient5, patient6, patient7 };
foreach (var patient in patients)
{
    IDataStore<Patient>.Create(patient);
}


var pastCondition1 = new Dictionary<string, DateTime>()
{
    {"Malaria",new DateTime(2020,5,15)},
    {"High blood pressure",new DateTime(2018,2,25)},
    {"Influenza",new DateTime(2016,8,5)},
};
var pastCondition2 = new Dictionary<string, DateTime>()
{
    {"Cough",new DateTime(2021,5,19)},
    {"Typhoid",new DateTime(2008,2,20)},
    {"Appendicitis",new DateTime(2005,8,15)},
};
var pastCondition3 = new Dictionary<string, DateTime>()
{
    {"Malaria",new DateTime(2020,5,15)},
    {"High blood pressure",new DateTime(2018,2,25)},
    {"Influenza",new DateTime(2016,8,5)},
};
var pastCondition4 = new Dictionary<string, DateTime>()
{
    {"Cough",new DateTime(2021,5,19)},
    {"Typhoid",new DateTime(2008,2,20)},
    {"Appendicitis",new DateTime(2005,8,15)},
};
var pastCondition5 = new Dictionary<string, DateTime>()
{
    {"Cough",new DateTime(2021,5,19)},
    {"Typhoid",new DateTime(2008,2,20)},
    {"Appendicitis",new DateTime(2005,8,15)},
};
var pastCondition6 = new Dictionary<string, DateTime>()
{
    {"Malaria",new DateTime(2020,5,15)},
    {"High blood pressure",new DateTime(2018,2,25)},
    {"Influenza",new DateTime(2016,8,5)},
};
var pastCondition7 = new Dictionary<string, DateTime>()
{
    {"Malaria",new DateTime(2020,5,15)},
    {"High blood pressure",new DateTime(2018,2,25)},
    {"Influenza",new DateTime(2016,8,5)},
};
var medicalHistory1 = new MedicalHistory() { PastConditions = pastCondition1, Patient = patient1 };
var medicalHistory2 = new MedicalHistory() { PastConditions = pastCondition2, Patient = patient2 };
var medicalHistory3 = new MedicalHistory() { PastConditions = pastCondition3, Patient = patient3 };
var medicalHistory4 = new MedicalHistory() { PastConditions = pastCondition4, Patient = patient4 };
var medicalHistory5 = new MedicalHistory() { PastConditions = pastCondition5, Patient = patient5 };
var medicalHistory6 = new MedicalHistory() { PastConditions = pastCondition6, Patient = patient6 };
var medicalHistory7 = new MedicalHistory() { PastConditions = pastCondition7, Patient = patient7 };

var medicalHistories = new List<MedicalHistory>() { medicalHistory1, medicalHistory2, medicalHistory3, medicalHistory4, medicalHistory5, medicalHistory6, medicalHistory7 };
foreach (var medicalHistory in medicalHistories)
{
    IDataStore<MedicalHistory>.Create(medicalHistory);
}

var appointment1 = new Appointment(patient1, doctor2, new DateTime(2022, 5, 2), hospital);
var appointment2 = new Appointment(patient2, doctor3, new DateTime(2022, 5, 23), hospital);
var appointment3 = new Appointment(patient3, doctor4, new DateTime(2022, 5, 31), hospital);
var appointment4 = new Appointment(patient4, doctor1, new DateTime(2022, 2, 21), hospital);
var appointment5 = new Appointment(patient5, doctor5, new DateTime(2022, 8, 28), hospital);
var appointment6 = new Appointment(patient6, doctor2, new DateTime(2022, 12, 12), hospital);
var appointments = new List<Appointment>() { appointment1, appointment2, appointment3, appointment4, appointment5, appointment6 };

foreach (var appointment in appointments)
{
    IDataStore<Appointment>.Create(appointment);
}

hospital.Receptionist = receptionist;
IDataStore<Hospital>.Update(hospital);

doctor2.Appointments.Enqueue(appointment1);
doctor2.Appointments.Enqueue(appointment5);
doctor1.Appointments.Enqueue(appointment4);
doctor3.Appointments.Enqueue(appointment2);
doctor4.Appointments.Enqueue(appointment3);
doctor5.Appointments.Enqueue(appointment5);
foreach (var doctor in doctors)
{
    IDataStore<Doctor>.Update(doctor);
}


//Hospital
//doctors
//nurses
//pharmacists
//Receptionist
//Accountant
//Patients

//doctor
//name
//Id
//queue of appointments
//seePatients(dequeques the queue)
//consultation fee

//nurses
//name and Id

//pharmacist
//a presciption at a time
//name and Id

//Accountant
//Recieves a  bills and calculates the balance/outstanding for them)


//patient
// a hospital
// hospital number
// PatientName
// Patient contact
//medical conditions(dictionary of past conditions and date of diagnosis)
// Gender
//-registered patients
//registration number
// an appointment
//BookAppointment-
// takes a doctor
//creates a new instance of an appointment

//Appointment
// a doctor(has a consultation fee)
//a patient
// has a day and time 
// a hospital
// a list of Drugs(prescription)
// a bill-(should have total amount to be paid and amount paid by patient, and also outstanding, recieve payment method)
//ReviewMedicalCondition
//AdiministerDrugs-populate the list of drugs(for each time a drug is instantiated,increase its count)
//BillManagement - loop through the list of drugs and add their price + doctor's consultation fee)

//Drug
//Id and name
//price
//CountOfPurchase


//Recieptionist
//name, Id
//ValidateAppointment(takes in a patient)
//- checks if the patient is registered 
//- if registered, check if patient.appointment is null and creates one if it is
//- if unregistered, creates an instance of an appointment and adds to the appointment table 





