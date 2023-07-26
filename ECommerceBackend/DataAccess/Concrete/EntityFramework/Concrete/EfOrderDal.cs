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
    public class EfOrderDal : EfEntityRepositoryBase<ECommerceDbContext, Order>, IOrderDal
    {
        public OrderDetailDto? GetOrderDetail(uint orderId)
        {
            using (ECommerceDbContext context = new())
            {
                var queryResult = from order in context.Orders
                                  where order.Id == orderId

                                  join seller in context.Sellers
                                  on order.SellerId equals seller.Id

                                  join customer in context.Customers
                                  on order.CustomerId equals customer.Id

                                  join product in context.Products
                                  on order.ProductId equals product.Id

                                  join measure in context.MeasureUnits
                                  on order.MesureUnitId equals measure.Id

                                  join currency in context.Currencies
                                  on order.CurrencyId equals currency.Id

                                  join city in context.Cities
                                  on order.CityId equals city.Id

                                  join country in context.Countries
                                  on city.CountryId equals country.Id

                                  select new OrderDetailDto
                                  {
                                      OrderId = order.Id,
                                      OrderDate = order.Date,
                                      OrderDescription = order.Description,

                                      SellerId = seller.Id,
                                      SellerName = seller.Name,

                                      CustomerId = customer.Id,
                                      CustomerName = customer.Name,

                                      ProductId = product.Id,
                                      ProductName = product.Name,
                                      ProductDescription = product.Description,

                                      ProductAmount = order.Amount,
                                      MeasureSymbol = measure.Symbol,
                                      MeasureDescription = measure.Description,

                                      OrderUnitPrice = order.UnitPrice,
                                      CurrencyCode=currency.Code,
                                      CurrencySymbol=currency.Symbol,

                                      ShipmentCountryName=country.Name,
                                      ShipmentCityName=city.Name,
                                      ShipmentAddressDescription=order.AddressDescription,
                                      ShipmentPostalCode=order.ShipPostalCode
                                  };

                return queryResult.FirstOrDefault();

                return queryResult.FirstOrDefault();
            }
        }
    }
}
