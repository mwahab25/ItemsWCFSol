using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ItemsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //// TODO: Add your service operations here
        //[OperationContract]      
        //string InsertCategories(Categories catinfo);

        ////[OperationContract]
        ////string UpdateCategories(int id,Categories catinfo);

        //[OperationContract]
        //string DeleteCategories(int id);

        //[OperationContract]
        //string InsertItems(Items iteminfo);


        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "jsoncats")]
        List<Category> GetAllCategories();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "jsoncatsAr")]
        List<CatsAr> GetAllCategoriesAr();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "jsoncatsEn")]
        List<CatsEn> GetAllCategoriesEn();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "jsonitemsAr/{id}")]
        List<CatItemsAr> GetAllItemsAr(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "jsonitemsEn/{id}")]
        List<CatItemsEn> GetAllItemsEn(string id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Categories
    {
        string category_nameAr = string.Empty;
        string category_nameEn=string.Empty;
        string category_image= string.Empty;
        [DataMember]
        public string Category_nameAr
        {
            get { return category_nameAr; }
            set { category_nameAr = value; }
        }
        [DataMember]
        public string Category_nameEn
        {
            get { return category_nameEn; }
            set { category_nameEn = value; }
        }
        [DataMember]
        public string Category_image
        {
            get { return category_image; }
            set { category_image = value; }
        }

    }

    [DataContract]
    public class Items
    {
        string item_nameAr = string.Empty;
        string item_nameEn = string.Empty;
        string item_descriptionAr = string.Empty;
        string item_descriptioneEn = string.Empty;
        string item_size = string.Empty;
        decimal item_price;
        string item_size2 = string.Empty;
        decimal item_price2;
        string item_image = string.Empty;
        int category_id;

        [DataMember]
        public string Item_nameAr
        {
            get { return item_nameAr; }
            set { item_nameAr = value; }
        }
        [DataMember]
        public string Item_nameEn
        {
            get { return item_nameEn; }
            set { item_nameEn = value; }
        }
        [DataMember]
        public string Item_descriptionAr
        {
            get { return item_descriptionAr; }
            set { item_descriptionAr = value; }
        }
        [DataMember]
        public string Item_descriptionEn
        {
            get { return item_descriptioneEn; }
            set { item_descriptioneEn = value; }
        }
        [DataMember]
        public string Item_size
        {
            get { return item_size; }
            set { item_size = value; }
        }
        [DataMember]
        public decimal Item_price
        {
            get { return item_price; }
            set { item_price = value; }
        }
        [DataMember]
        public string Item_size2
        {
            get { return item_size2; }
            set { item_size2 = value; }
        }
        [DataMember]
        public decimal Item_price2
        {
            get { return item_price2; }
            set { item_price2 = value; }
        }
        [DataMember]
        public string Item_image
        {
            get { return item_image; }
            set { item_image = value; }
        }
        [DataMember]
        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }
    }

}
