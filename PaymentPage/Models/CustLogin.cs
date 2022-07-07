using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentPage.Models
{
    public class CustLogin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Username { get;}
        public string Password { get;}
    }
}
