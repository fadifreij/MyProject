using ECommerce.Domain.Common;
using ECommerce.ServiceAbstraction.Common;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UnitTest
{
    public class GenericRepositoryTests
    {
        private readonly Mock<IGenericRepository<BaseEntity>> _mockRepository;
        private readonly BaseEntity _testEntity;

        public GenericRepositoryTests()
        {
            _mockRepository = new Mock<IGenericRepository<BaseEntity>>();
            _testEntity = new BaseEntity { Id = 1 };
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllEntities()
        {
            // Arrange
            var entities = new List<BaseEntity> { _testEntity };
            _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(entities);

            // Act
            var result = await _mockRepository.Object.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(_testEntity, result.First());
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnEntityById()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.GetByIdAsync(_testEntity.Id)).ReturnsAsync(_testEntity);

            // Act
            var result = await _mockRepository.Object.GetByIdAsync(_testEntity.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(_testEntity, result);
        }

        [Fact]
        public async Task FindAsync_ShouldReturnEntitiesMatchingPredicate()
        {
            // Arrange
            var entities = new List<BaseEntity> { _testEntity };
            Expression<Func<BaseEntity, bool>> predicate = e => e.Id == _testEntity.Id;
            _mockRepository.Setup(repo => repo.FindAsync(predicate)).ReturnsAsync(entities);

            // Act
            var result = await _mockRepository.Object.FindAsync(predicate);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(_testEntity, result.First());
        }

        [Fact]
        public async Task AddAsync_ShouldAddEntity()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.AddAsync(_testEntity)).Returns(Task.CompletedTask);

            // Act
            await _mockRepository.Object.AddAsync(_testEntity);

            // Assert
            _mockRepository.Verify(repo => repo.AddAsync(_testEntity), Times.Once);
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.UpdateAsync(_testEntity)).Returns(Task.CompletedTask);

            // Act
            await _mockRepository.Object.UpdateAsync(_testEntity);

            // Assert
            _mockRepository.Verify(repo => repo.UpdateAsync(_testEntity), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_ShouldDeleteEntityById()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.DeleteAsync(_testEntity.Id)).Returns(Task.CompletedTask);

            // Act
            await _mockRepository.Object.DeleteAsync(_testEntity.Id);

            // Assert
            _mockRepository.Verify(repo => repo.DeleteAsync(_testEntity.Id), Times.Once);
        }
    }
}
