using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory _dbFactory;
        private IUnitOfWork _unitOfWork;
        private IPostCategoryRepository _objRepository;

        [TestInitialize]
        public void Initialize()
        {
            _dbFactory = new DbFactory();
            _unitOfWork = new UnitOfWork(_dbFactory);
            _objRepository = new PostCategoryRepository(_dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory()
            {
                Name = "Tets category",
                Alias = "test-category",
                Status = true
            };

            var result = _objRepository.Add(category);
            _unitOfWork.Commit();

            Assert.AreEqual("", result);
        }
    }
}