﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI_QLKH.Models
{
    public partial class NCC
    {
        public NCC()
        {
            DonNhap = new HashSet<DonNhap>();
        }

        public string NCC_ID { get; set; }
        public string NCC_Name { get; set; }
        public string NCC_Address { get; set; }
        public int? NCC_Phone { get; set; }
        public string Quantity { get; set; }

        public virtual ICollection<DonNhap> DonNhap { get; set; }
    }
}