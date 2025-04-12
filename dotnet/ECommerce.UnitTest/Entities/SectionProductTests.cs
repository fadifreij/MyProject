using E_Commerce.Domain.Entities;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UnitTest.Entities
{
    public class SectionProductTests
    {
        [Fact]
        public void SectionProduct_ShouldInitialize_SectionAndProduct()
        {
            // Arrange
            var sectionProduct = new SectionProduct();

            // Act
            var section = sectionProduct.Section;
            var product = sectionProduct.Product;

            // Assert
            Assert.NotNull(section);
            Assert.NotNull(product);
        }

        [Fact]
        public void SectionProduct_ShouldSet_SectionIdAndProductId()
        {
            // Arrange
            var sectionProduct = new SectionProduct
            {
                SectionId = 1,
                ProductId = 101
            };

            // Act
            var sectionId = sectionProduct.SectionId;
            var productId = sectionProduct.ProductId;

            // Assert
            Assert.Equal(1, sectionId);
            Assert.Equal(101, productId);
        }

        [Fact]
        public void SectionProduct_ShouldSet_SectionAndProductNavigationProperties()
        {
            // Arrange
            var section = new Section { SectionName = "Electronics" };
            var product = new Product { ProductName = "Laptop" };
            var sectionProduct = new SectionProduct
            {
                Section = section,
                Product = product,
                SectionId = section.Id,  // Assuming SectionId is auto-generated after SaveChanges()
                ProductId = product.Id   // Same for ProductId
            };

            // Act
            var sectionId = sectionProduct.SectionId;
            var productId = sectionProduct.ProductId;

            // Assert
            Assert.Equal(section.Id, sectionId);  // Assuming SectionId is set correctly
            Assert.Equal(product.Id, productId);  // Assuming ProductId is set correctly
            Assert.Equal("Electronics", sectionProduct.Section.SectionName);
            Assert.Equal("Laptop", sectionProduct.Product.ProductName);
        }

        

    }
}
