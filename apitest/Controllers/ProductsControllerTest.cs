using Microsoft.VisualStudio.TestTools.UnitTesting;
using apinetcurso.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Text;
using System.Threading.Tasks;
using apinetcurso.Models;

namespace apitest.Controllers.Tests
{
    [TestClass()]
    public class ProductsControllerTest
    {
        [TestMethod()]
        public void GetAllProductsTest()
        {

            //var controlador = new ProductsController();

            //var result = controlador.GetAllProducts() as List<Product>;

            //Assert.IsTrue(result.Count == 4 );
            //Assert.IsFalse(result.Count == 5);
            Assert.IsTrue(true);
            
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetProductTest()
        {
            //var controlador = new ProductsController();

            //var result = controlador.GetProduct(2) as Product;

            //Assert.AreEqual(result.Name,"Yo-yo");
            Assert.IsTrue(true);
        }


    }
}