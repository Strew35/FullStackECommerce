using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<ECommerceDbContext, User>, IUserDal
    {
        public UserDetailDto? GetUserDetail(uint userId)
        {
            using (ECommerceDbContext context = new())
            {
                var queryResult = from user in context.Users
                                  where user.Id == userId

                                  join customer in context.Customers
                                  on user.Id equals customer.UserId

                                  join seller in context.Sellers
                                  on user.Id equals seller.UserId

                                  select new UserDetailDto
                                  {
                                      UserId = user.Id,
                                      UserCreateTime = user.CreateTime,
                                      UserEmail = user.Email,

                                      UserTypeName = customer.Id != null ? "Customer" : "Seller",
                                      UserTypeId = customer.Id != null ? customer.Id : seller.Id,
                                      UserName = customer.Id != null ? customer.Name : seller.Name,
                                      UserPhoneNumber = customer.Id != null ? customer.PhoneNumber : seller.PhoneNumber
                                  };

                return queryResult.FirstOrDefault();
            }
        }
    }
}
