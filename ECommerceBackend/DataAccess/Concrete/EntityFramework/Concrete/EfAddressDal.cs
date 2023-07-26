using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Concrete
{
    public class EfAddressDal : EfEntityRepositoryBase<ECommerceDbContext, Address>, IAddressDal
    {
        public AddressDetailDto? GetAddressDetailByAddressId(uint addressId)
        {
            using (ECommerceDbContext context = new())
            {
                var queryResult = from address in context.Addresses
                                  where address.Id == addressId

                                  join city in context.Cities
                                  on address.CityId equals city.Id

                                  join country in context.Countries
                                  on city.CountryId equals country.Id

                                  select new AddressDetailDto
                                  {
                                      AddressId = address.Id,
                                      CountryName = country.Name,
                                      CityName = city.Name,
                                      PostalCode = address.PostalCode,
                                      AddressDescription = address.Description
                                  };

                return queryResult.FirstOrDefault();
            }
        }

        public List<AddressDetailDto>? GetAddressDetailsByUserId(uint userId)
        {
            using (ECommerceDbContext context = new())
            {
                var queryResult= from address in context.Addresses
                                 where address.UserId == userId

                                 join city in context.Cities
                                 on address.CityId equals city.Id

                                 join country in context.Countries
                                 on city.CountryId equals country.Id

                                 select new AddressDetailDto
                                 {
                                     AddressId = address.Id,
                                     CountryName = country.Name,
                                     CityName = city.Name,
                                     PostalCode = address.PostalCode,
                                     AddressDescription = address.Description
                                 };

                return queryResult.ToList();
            }
        }
    }
}
