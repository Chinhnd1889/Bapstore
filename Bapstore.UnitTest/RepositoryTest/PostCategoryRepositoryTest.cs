using Bapstore.Data.Infrastructure;
using Bapstore.Data.Repository;
using Bapstore.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Bapstore.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCateogry_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();

            Assert.AreEqual(5, list.Count);
        }

        [TestMethod]
        public void PostCateogry_Repository_Create()
        {
            PostCategory category = new PostCategory()
            {
                Name = "Test Category",
                Alias = "Test-Category",
                Status = true
            };

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.ID);
        }
    }
}
