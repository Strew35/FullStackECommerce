using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            if (order.AddressDescription == null) return new ErrorResult(Messages.OrderAddressIsEmpty);
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<Order>?> GetAll()
        {
            return new SuccessDataResult<List<Order>?>(_orderDal.GetAll());
        }

        public IDataResult<Order?> GetByOrderId(uint orderId)
        {
            return new SuccessDataResult<Order?>(_orderDal.Get(order => order.Id == orderId));
        }
    }
}
