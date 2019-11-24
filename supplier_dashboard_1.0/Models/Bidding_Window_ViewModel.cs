using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace supplier_dashboard_1._0.Models
{
    public class Bidding_Window_ViewModel
    {
        //item table
        public string item_name { get; set; }
        public Nullable<int> item_category_code { get; set; }
        public Nullable<int> item_brand_code { get; set; }
        public string item_desc { get; set; }
        public Nullable<int> unit_price { get; set; }
        public string measured_in { get; set; }
        public string size { get; set; }

        //item_brand table
        //public int item_brand_code { get; set; }
        public string item_brand_name { get; set; }

        //item_category table
        //public int item_category_code { get; set; }
        public string item_category_name { get; set; }

        //quotation table        
        public Nullable<int> vendor_user_id { get; set; }
        public Nullable<int> customer_user_id { get; set; }
        public Nullable<System.DateTime> submission_date { get; set; }
        public Nullable<System.DateTime> written_on { get; set; }
        public Nullable<int> order_code { get; set; }
        public Nullable<int> total_price { get; set; }

        //quotation_items table
        public Nullable<int> quotation_code { get; set; }
        public Nullable<int> item_code { get; set; }
        public Nullable<int> quantity { get; set; }
        public string desc_ { get; set; }
        public Nullable<int> value_of_good { get; set; }

        //system_order table

        public Nullable<int> customer_user_ID { get; set; }
        public Nullable<int> supplier_user_ID { get; set; }
        //public string desc_ { get; set; }
        public Nullable<System.DateTime> start_order_date { get; set; }
        public Nullable<System.DateTime> end_order_date { get; set; }
        public string commpletion_percentage { get; set; }
    }
}