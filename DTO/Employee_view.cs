using System;

namespace DTO
{
    public class Employee_view
    {
        public int ID_User { get; set; }
        public string User_Name { get; set; }
        public string User_Position { get; set; }
        public string Phone_number { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateStartWork { get; set; }
        public int NumberOfDayWork { get; set; }
        public string UserNameLogin { get; set; }
        public string PasswordLogin { get; set; }
        public string Status { get; set; }
    }
}
