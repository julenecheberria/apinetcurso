using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Text;
using System.Threading.Tasks;
using apinetcurso.Models;

namespace ProductsApp.Controllers.Tests
{
    [TestClass()]
    public class ProductsControllerTest
    {
        [TestMethod()]
        public void GetAllProductsTest()
        {

            var controlador = new ProductsController();

            var result = controlador.GetAllProducts() as List<Product>;

            Assert.IsTrue(result.Count == 4 );
            Assert.IsFalse(result.Count == 5);
            
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetProductTest()
        {
            var controlador = new ProductsController();

            var result = controlador.GetProduct(2) as Product;

            Assert.AreEqual(result.Name,"Yo-yo");
        }


    }
}