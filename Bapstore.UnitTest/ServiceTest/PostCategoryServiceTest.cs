using Bapstore.Data.Infrastructure;
using Bapstore.Data.Repository;
using Bapstore.Model.Models;
using Bapstore.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Bapstore.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            listCategory = new List<PostCategory>()
            {
                new PostCategory(){ ID = 1, Name = "DM1", Status = true },
                new PostCategory(){ ID = 2, Name = "DM2", Status = false },
                new PostCategory(){ ID = 3, Name = "DM3", Status = true }
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            _mockRepository.Setup(m => m.GetAll(null)).Returns(listCategory);

            var result = _categoryService.GetAll() as List<PostCategory>;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory postCategory = new PostCategory()
            {
                Name = "Test",
                Alias = "test",
                Status = true
            };

            _mockRepository.Setup(m => m.Add(postCategory)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });

            var result = _categoryService.Add(postCategory);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
