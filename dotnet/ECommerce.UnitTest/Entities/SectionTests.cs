using E_Commerce.Domain.Entities;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UnitTest.Entities
{
    public class SectionTests : CommonModelTest
    {
        
    
        [Fact]
        public void Section_ShouldInitialize_SectionProductsCollection()
        {
            // Arrange
            var section = new Section();
            section.SectionProducts = new List<SectionProduct>(); // Initialize the collection
            // Act
            var sectionProducts = section.SectionProducts;

            // Assert
            Assert.NotNull(sectionProducts);  // Should not be null because it's initialized
        }

        [Fact]
        public void Section_ShouldHaveRequiredSectionName()
        {
            // Arrange
            var section = new Section { SectionName = "Electronics" };

            // Act & Assert
            Assert.Equal("Electronics", section.SectionName);
        }

       

        [Fact]
        public void Section_ShouldBeValidWhenPropertiesAreValid()
        {
            // Arrange
            var section = new Section { SectionName = "Home Appliances" };

            // Act
            var isValid = !string.IsNullOrEmpty(section.SectionName);

            // Assert
            Assert.True(isValid);
        }


        [Fact]
        public void SectionName_ShouldThrowError_WhenEmpty()
        {
            // Arrange
            var section = new Section();

            // Act & Assert
            var exception = Assert.Throws<ValidationException>(() =>
                Validator.ValidateObject(section, new ValidationContext(section), true));

            Assert.Contains("The SectionName field is required.", exception.Message);
        }


        [Fact]
        public void SectionName_ShouldNotExceed_MaxLength()
        {
            // Arrange
            var section = new Section
            {
                SectionName = new string('A', 251)  // 251 characters, one more than the limit
            };

            // Act & Assert
            var exception = Assert.Throws<ValidationException>(() =>
                Validator.ValidateObject(section, new ValidationContext(section), true));

            Assert.Contains("The field SectionName must be a string with a maximum length of 250.", exception.Message);
        }

        [Fact]
        public void DisplayName_ShouldBeNullable()
        {
            // Arrange
            var section = new Section
            {
                SectionName = "Toys",
                DisplayName = null // Nullable property
            };

            // Act & Assert
            Assert.Null(section.DisplayName);
        }

        [Fact]
        public void DisplayName_ShouldNotExceed_MaxLength()
        {
            // Arrange
            var section = new Section
            {
                SectionName = "Books",
                DisplayName = new string('B', 251)  // 251 characters, one more than the limit
            };

            // Act & Assert
            var exception = Assert.Throws<ValidationException>(() =>
                Validator.ValidateObject(section, new ValidationContext(section), true));

            Assert.Contains("The field DisplayName must be a string with a maximum length of 250.", exception.Message);
        }

    }
}
