using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int parentId);

        PostCategory GetById(int id);
    }

    public class PostCategoryService : IPostCategoryService
    {
        private readonly IPostCategoryService _postCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryService postRepository, UnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            _postCategoryRepository        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentId)
        {
            throw new NotImplementedException();
        }

        public PostCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }
    }
}