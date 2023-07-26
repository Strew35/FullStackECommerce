using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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
    public class EfProductDal : EfEntityRepositoryBase<ECommerceDbContext, Product>, IProductDal
    {
        public ProductDetailDto? GetProductDetail(uint productId)
        {
            using (ECommerceDbContext context = new())
            {
                var queryResult = from product in context.Products
                                  where product.Id == productId

                                  join category in context.Categories
                                  on product.CategoryId equals category.Id

                                  join currency in context.Currencies
                                  on product.CurrencyId equals currency.Id

                                  join measureUnit in context.MeasureUnits
                                  on product.MeasureUnitId equals measureUnit.Id

                                  select new ProductDetailDto
                                  {
                                      ProductId = product.Id,
                                      ProductName = product.Name,
                                      ProductDescription = product.Description,

                                      CategoryName = category.Name,

                                      UnitPrice = product.UnitPrice,
                                      CurrencySymbol = currency.Symbol,
                                      CurrencyCode = currency.Code,

                                      UnitsInStock = product.UnitsInStock,
                                      MeasureUnitSymbol = measureUnit.Symbol,
                                      MeasureUnitDescription = measureUnit.Description
                                  };

                return queryResult.FirstOrDefault();
            }
        }

        public ProductSellerDetailDto? GetProductSellerAddressDetail(uint productId, IAddressDal addressDal)
        {
            using (ECommerceDbContext context = new())
            {
                var queryResult = from product in context.Products
                                  where product.Id == productId

                                  join seller in context.Sellers
                                  on product.SellerId equals seller.Id

                                  join user in context.Users
                                  on seller.UserId equals user.Id

                                  select new ProductSellerDetailDto
                                  {
                                      ProductId = product.Id,
                                      ProductName = product.Name,
                                      ProductDescription = product.Description,

                                      SellerId = seller.Id,
                                      SellerName = seller.Name,
                                      SellerDescription = seller.Description,
                                      SellerAddressDetails = addressDal.GetAddressDetailsByUserId(seller.UserId)
                                  };

                return queryResult.FirstOrDefault();
            }
        }
    }
}
