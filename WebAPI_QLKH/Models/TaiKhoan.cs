﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI_QLKH.Models;

public partial class TaiKhoan
{
    public string UserID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Description { get; set; }

    public string RoleID { get; set; }

    public virtual ICollection<NhanVien> NhanVien { get; set; } = new List<NhanVien>();

    public virtual Role Role { get; set; }
}