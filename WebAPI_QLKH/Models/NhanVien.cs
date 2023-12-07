﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI_QLKH.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            ChiNhanh = new HashSet<ChiNhanh>();
            DonNhap = new HashSet<DonNhap>();
            DonXuat = new HashSet<DonXuat>();
            UserNavigation = new HashSet<User>();
        }

        public string NV_ID { get; set; }
        public string NV_Name { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Sex { get; set; }
        public int? Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CN_ID { get; set; }
        public string UserID { get; set; }

        public virtual ChiNhanh CN { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ChiNhanh> ChiNhanh { get; set; }
        public virtual ICollection<DonNhap> DonNhap { get; set; }
        public virtual ICollection<DonXuat> DonXuat { get; set; }
        public virtual ICollection<User> UserNavigation { get; set; }
    }
}