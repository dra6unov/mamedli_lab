//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class STORE
    {
        public int ID { get; set; }
        public int LOGIN_ID { get; set; }
        public int PROD_ID { get; set; }
        public string ADRESS { get; set; }
    
        public virtual PRODUCTS PRODUCTS { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
