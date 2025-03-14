using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public class Passenger
    {
        //public int PassengerId { get; set; }
        [Display(Name ="date of birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        //[MaxLength(25,ErrorMessage ="longueur max est 25")]
        //[MinLength(3,ErrorMessage ="longueur min est 3")]
        //public string? FirstName { get; set; }
        //[MaxLength(25, ErrorMessage = "longueur max est 25")]
        //[MinLength(3, ErrorMessage = "longueur min est 3")]
        //public string? LastName { get; set; }
        public FullName FullName { get; set; }
        [Key]
        [StringLength(7)]
        public string? PassportNumber { get; set; }
        [RegularExpression(@"^[0-9][8]$")]
        public string? TelNumber { get; set; }
        //public ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Ticket> ListTicket { get; set; }
        public override string ToString()
        {
            return "FirstName=" + FullName.FirstName + "LastName=" + FullName.LastName;
        }
        //public bool CheckProfile(string FirstName , string LastName)
        //{
        //    return this.FirstName == FirstName && this.LastName == LastName;
        //}
        //public bool CheckProfile(string FirstName, string LastName,string Email)
        //{
        //    return this.FirstName == FirstName && this.LastName == LastName && this.EmailAddress== Email;
        //}
        public bool CheckProfile(string FirstName, string LastName, string Email=null)
        {
            if (Email == null)
            {
                return FullName.FirstName == FirstName && FullName.LastName == LastName;
            }
            else
            {
                return FullName.FirstName == FirstName && FullName.LastName == LastName && this.EmailAddress == Email;
            }
        }

        public virtual void PassengerType ()
        {
            Console.WriteLine("I'am a passanger");
        }

    }
}
