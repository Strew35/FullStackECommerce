using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>?> GetProducts()
        {
            return new SuccessDataResult<List<Product>?>(_productDal.GetAll());
        }

        public IDataResult<Product?> GetProductById(uint productId)
        {
            return new SuccessDataResult<Product?>(_productDal.Get(product => product.Id == productId));
        }
    }
}
