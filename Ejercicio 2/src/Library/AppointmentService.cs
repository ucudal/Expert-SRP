using System;

namespace Library
{
    public class Doctor{
        public string name;
        public string specialty;

        public string createDoctor(string myName, string mySpecialty){

            if(string.IsNullOrEmpty(myName)) return "Debe ingresar un nombre valido.";
            this.name = myName;
            if(string.IsNullOrEmpty(mySpecialty)) return "Debe ingresar una especialidad valido.";
            this.name = mySpecialty;

            return "Doctor creado de forma exitosa.";

        }

    }

    public class Patient{
        public string name;
        public int age;
        public string phoneNumber;

        public string createPatient(string myName, string myPhoneNumber, int myAge){

            if(string.IsNullOrEmpty(myName)) return "Debe ingresar un nombre valido.";
            this.name = myName;
            if(string.IsNullOrEmpty(myPhoneNumber)) return "Debe ingresar un numero valido.";
            this.phoneNumber = myPhoneNumber;
            if(myAge > 0) return "Debe ingresar un numero valido.";
            this.age = myAge;

            return "Paciente creado de forma exitosa.";
        }

    }

    public class Apointment{
        string place;
        DateTime date;
        string id;
        bool isValid = false;
        Doctor doctorAssigned;
        Patient patient;

        public string scheduleAppointment(Patient myPatient, Doctor myDoctor, string myId, string myPlace, DateTime myDate)
        {
            if (string.IsNullOrEmpty(myId)) return "Unable to schedule appointment, 'id' is required.";
            this.id = myId;
            if (string.IsNullOrEmpty(myPlace)) return "Unable to schedule appointment, 'appoinment place' is required.";
            place = myPlace;
            if (myDoctor == null) return "Unable to schedule appointment, 'appoinment date' is required.";
            doctorAssigned = myDoctor;
            if (myPatient == null) return "Unable to schedule appointment, 'appoinment date' is required.";
            patient = myPatient;
            date = myDate;

            isValid = true;
            return "Appointment scheduled.";
        }

        public bool scheduleValid(){
            return isValid;
        }
    }

}
