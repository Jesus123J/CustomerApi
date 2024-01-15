using System.ComponentModel.DataAnnotations;

namespace CustomersApi.dtos
{
    public class CreateCustomerDto
    {
        [Required(ErrorMessage = "El nombre tiene que estar especificado")]
        public string FirtsName { get; set; }

        [Required(ErrorMessage = "El Apellido tiene que estar especificado")]
        public string LastName { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$" , ErrorMessage = "El Correo es en formato incorrecto")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
