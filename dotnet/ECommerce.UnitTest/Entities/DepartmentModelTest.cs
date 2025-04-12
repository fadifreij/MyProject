using E_Commerce.Domain.Entities;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UnitTest.Entities
{
    public class DepartmentModelTest : CommonModelTest
    {
        [Fact]
        public void Department_WithValidData_ShouldPassValidation()
        {
            var department = new Department
            {
                DepartmentName = "Human Resources",
                CategoryId = 1,
                Category = new Category { CategoryName = "Admin" }
            };

            var results = ValidateModel(department);

            Assert.Empty(results);
        }
        [Fact]
        public void Department_WithoutDepartmentName_ShouldFailValidation()
        {
            var department = new Department
            {
                DepartmentName = "",
                CategoryId = 1
            };

            var results = ValidateModel(department);

            Assert.Contains(results, r => r.MemberNames.Contains(nameof(Department.DepartmentName)));
        }

        [Fact]
        public void Department_WithTooLongDepartmentName_ShouldFailValidation()
        {
            var department = new Department
            {
                DepartmentName = new string('B', 251), // Exceeds 250 characters
                CategoryId = 1
            };

            var results = ValidateModel(department);

            Assert.Contains(results, r => r.MemberNames.Contains(nameof(Department.DepartmentName)));
        }
        [Fact]
        public void Department_WithZeroCategoryId_ShouldPassValidation()
        {
            // This test checks behavior if CategoryId is zero.
            // It's valid unless your business logic disallows 0.
            var department = new Department
            {
                DepartmentName = "Legal",
                CategoryId = 0
            };

            var results = ValidateModel(department);

            Assert.Empty(results);
        }
        [Fact]
        public void Department_CategoryNavigationProperty_CanBeNull()
        {
            var department = new Department
            {
                DepartmentName = "Finance",
                CategoryId = 5,
                Category = null // Should be allowed, unless [Required]
            };

            var results = ValidateModel(department);

            Assert.Empty(results);
        }
    }
}
