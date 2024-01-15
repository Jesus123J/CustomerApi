using CustomersApi.dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CustomersApi.Repositories
{
    public class CustomerDataBaseContext : DbContext

    {

        public CustomerDataBaseContext(DbContextOptions<CustomerDataBaseContext> options)
            : base(options)
        {
        
        }   
       public  DbSet<CustomerEntity>Customer { get; set; }
       public async Task<CustomerEntity> Get(long? id)
        {
            return await Customer.FirstAsync(x => x.Id == id);
        }


        public async Task<CustomerEntity> Add(CreateCustomerDto customerDto)
        {
            CustomerEntity entity = new CustomerEntity(){ 
            
                Id = null,
                Address = customerDto.Address,
                Email = customerDto.Email,       
                FirtsName = customerDto.FirtsName,
                LastName = customerDto.LastName,

            };
            EntityEntry<CustomerEntity> response = await Customer.AddAsync(entity);
            await SaveChangesAsync();
            return  await Get(response.Entity.Id = entity.Id ?? throw new Exception("No se reconoce"));
        }

    }
    public class CustomerEntity
    {
        public long? Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
