﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

#nullable disable

namespace IGO.Models
{
    public partial class TCustomer
    {
        public TCustomer()
        {
            TCollections = new HashSet<TCollection>();
            TFeedbackManagements = new HashSet<TFeedbackManagement>();
            TOrders = new HashSet<TOrder>();
            TShoppingCarts = new HashSet<TShoppingCart>();
        }

        public int FCustomerId { get; set; }
        public string FPassword { get; set; }
        public int? FCityId { get; set; }
        public string FAddress { get; set; }
        public string FLastName { get; set; }
        public string FFirstName { get; set; }
        public string FEmail { get; set; }
        public string FPhone { get; set; }
        public string FGender { get; set; }
        public string FBirth { get; set; }
        public string FSignUpDate { get; set; }
        public string FUserPhoto { get; set; }
        

        public virtual TCity FCity { get; set; }

        public virtual ICollection<TCollection> TCollections { get; set; }
        public virtual ICollection<TFeedbackManagement> TFeedbackManagements { get; set; }
        public virtual ICollection<TOrder> TOrders { get; set; }
        public virtual ICollection<TShoppingCart> TShoppingCarts { get; set; }
    }
}
