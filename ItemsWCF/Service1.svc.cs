using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ItemsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        //public string InsertCategories(Categories catinfo)
        //{
            //try
            //{
                //ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
                //Category newcat = new Category();
                //newcat.category_nameAr = catinfo.Category_nameAr;
                //newcat.category_nameEn = catinfo.Category_nameEn;
                //newcat.category_image = catinfo.Category_image;
                //context.Categories.InsertOnSubmit(newcat);
                //context.SubmitChanges();
                //return "Inserted Successfully";
            //}
            //catch
            //{
            //    return "Not Inserted Successfully";
            //}
        //}

        //public string UpdateCategories(int id,Categories catinfo)
        //{
        //    try
        //    {
        //        ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
        //        Category cat = context.Categories.Single(category => category.id == id);
        //        cat.category_nameAr = catinfo.Category_nameAr;
        //        cat.category_nameEn = catinfo.Category_nameEn;
        //        cat.category_image = catinfo.Category_image;
        //        context.SubmitChanges();

        //        return "Updated Successfully";
        //    }
        //    catch
        //    {
        //        return "Not Updated Successfully";
        //    }
        //}

        //public string DeleteCategories(int id)
        //{
        //    try
        //    {
        //        ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
        //        Category cat = context.Categories.Single(category => category.id == id);
        //        context.Categories.DeleteOnSubmit(cat);
        //        context.SubmitChanges();
        //        return "Deleted Successfully";
        //    }
        //    catch
        //    {
        //        return "Not Deleted Successfully";
        //    }
        //}

        //public string InsertItems(Items iteminfo)
        //{
        //    try
        //    {
        //        ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
        //        Item newitem = new Item();

        //        newitem.item_nameAr = iteminfo.Item_nameAr;
        //        newitem.item_nameEn = iteminfo.Item_nameEn;
        //        newitem.item_descrptionAr = iteminfo.Item_descriptionAr;
        //        newitem.item_descrptionEn = iteminfo.Item_descriptionEn;
        //        newitem.item_size = iteminfo.Item_size;
        //        newitem.item_price = iteminfo.Item_price;
                
        //        newitem.item_size2 = iteminfo.Item_size2;
        //        newitem.item_price2 = iteminfo.Item_price2;

        //        newitem.item_image = iteminfo.Item_image;
        //        newitem.category_id = iteminfo.Category_id;     

        //        context.Items.InsertOnSubmit(newitem);
        //        context.SubmitChanges();

        //        return "Inserted Successfully";
        //    }
        //    catch
        //    {
        //        return "Not Inserted Successfully";
        //    }
        //}

        public List<Category> GetAllCategories()
        {
            ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
            var res = from r in context.Categories select r;
            return res.ToList();
        }

        public List<CatsAr> GetAllCategoriesAr()
        {
            ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
            var res = from r in context.CatsArs select r;
            return res.ToList();
        }

        public List<CatsEn> GetAllCategoriesEn()
        {
            ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
            var res = from r in context.CatsEns select r;
            return res.ToList();
        }

        public List<CatItemsAr> GetAllItemsAr(string id)
        {
            ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
            var res = from r in context.CatItemsArs where r.category_id==Convert.ToInt32(id) select r;
            return res.ToList();
        }
        public List<CatItemsEn> GetAllItemsEn(string id)
        {
            ItemsDataClassesDataContext context = new ItemsDataClassesDataContext();
            var res = from r in context.CatItemsEns where r.category_id == Convert.ToInt32(id)
                      select r;
            return res.ToList();
        }

    }
}
