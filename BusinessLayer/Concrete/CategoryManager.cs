using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository ef;

        public CategoryManager()
        {
            ef = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            ef.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            ef.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            ef.Update(category);
        }

        public Category GetById(int id)
        {
            return ef.GetById(id);
        }

        public List<Category> GetList()
        {
            return ef.GetList();
        }
    }
}
