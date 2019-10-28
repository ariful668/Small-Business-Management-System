using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SmallBusinessManagement.Repository;
using SmallBusinessManagement.Model;

namespace SmallBusinessManagement.BLL
{
    public class CategoryManager
    {
        
        
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool AddCategory(Category category)
        {
            return _categoryRepository.AddCategory(category);
        }

        public List<Category> DisplayCategory()
        {
            return _categoryRepository.DisplayCategory();
        }

        public bool IsExistCode(Category category)
        {
            return _categoryRepository.IsExistCode(category);
        }

        public bool IsExistName(Category category)
        {
            return _categoryRepository.IsExistName(category);
        }

        public bool IsUpdateCategory(Category category)
        {
            return _categoryRepository.IsUpdateCategory(category);
        }

        public List<Category> SearchCategory(string criteria)
        {
            return _categoryRepository.SearchCategory(criteria);
        }

        public bool DeleteCategory(Category category)
        {
            return _categoryRepository.DeleteCategory(category);
        }
    }
}
