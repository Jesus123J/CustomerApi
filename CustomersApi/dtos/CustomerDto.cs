﻿namespace CustomersApi.dtos
{
    public class CustomerDto
    {
        public long? Id {  get; set; }
        public string FirtsName {  get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Address { get; set; }
    }
}
