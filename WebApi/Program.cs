using Domain.Entities;
using Infrastructure;

DoctorService dcDoctor = new DoctorService();

var doctor1 = new Doctor
{
    Id = 2,
    FullName = "Rahmatulloev Hikmatullo",
    Specialization = "djjdjdjd"
};
var doctor2 = new Doctor
{
    Id = 4,
    FullName = "Qrbonov Sayvali",
    Specialization = "ghjkkjhg"
};
var doctor3 = new Doctor
{
    Id = 6,
    FullName = "Abdulvohid Abdulvohidov",
    Specialization = "kjhghjk"
};

dcDoctor.Create(doctor1);
dcDoctor.Create(doctor2);
dcDoctor.Create(doctor3);

var doctors = dcDoctor.GetAll();

System.Console.WriteLine("--- Ruyxati аввала ---");
System.Console.WriteLine($"Id\tFullName\t\tHikmat");

foreach (var doctor in doctors)
{
    Console.WriteLine($"{doctor.Id}\t{doctor.FullName}\t{doctor.Specialization}");
}
var doctorForUpdate = new Doctor
{
    Id = 3,
    FullName = "Abdullo sayvaliev",
    Specialization = "sdfghj"
};
dcDoctor.Update(doctorForUpdate);

System.Console.WriteLine("\n--- Ba'di Update ---");
System.Console.WriteLine($"Id\tFullName\t\tSpecialization");

foreach (var doctor in doctors)
{
    Console.WriteLine($"{doctor.Id}\t{doctor.FullName}\t{doctor.Specialization}");
}
dcDoctor.Delete(3);
System.Console.WriteLine("\n--- Ba'di Delete ---");
System.Console.WriteLine($"Id\tFullName\t\tSpecialization");
foreach (var doctor in doctors)
{
    Console.WriteLine($"{doctor.Id}\t{doctor.FullName}\t{doctor.Specialization}");
}