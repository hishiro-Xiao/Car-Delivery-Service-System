//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Delivery_Service_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int Id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> car_id { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public string address { get; set; }
        public string phoneNum { get; set; }
    
        public virtual car car { get; set; }
        public virtual customer customer { get; set; }
    }
}
