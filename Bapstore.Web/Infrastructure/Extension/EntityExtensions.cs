using Bapstore.Model.Models;
using Bapstore.Web.Models;

namespace Bapstore.Web.Infrastructure.Extension
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.CreatedAt = postCategoryViewModel.CreatedAt;
            postCategory.CreatedBy = postCategoryViewModel.CreatedBy;
            postCategory.UpdatedAt = postCategoryViewModel.UpdatedAt;
            postCategory.UpdatedBy = postCategoryViewModel.UpdatedBy;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.Status = postCategoryViewModel.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.CategoryID = postViewModel.CategoryID;
            post.Image = postViewModel.Image;
            post.Description = postViewModel.Description;
            post.Content = postViewModel.Content;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotFlag = postViewModel.HotFlag;
            post.ViewCount = postViewModel.ViewCount;
            post.CreatedAt = postViewModel.CreatedAt;
            post.CreatedBy = postViewModel.CreatedBy;
            post.UpdatedAt = postViewModel.UpdatedAt;
            post.UpdatedBy = postViewModel.UpdatedBy;
            post.MetaDescription = postViewModel.MetaDescription;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.Status = postViewModel.Status;
        }
    }
}