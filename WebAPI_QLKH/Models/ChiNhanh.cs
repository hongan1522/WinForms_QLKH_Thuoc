﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI_QLKH.Models;

public partial class ChiNhanh
{
    public string CN_ID { get; set; }

    public string CN_Name { get; set; }

    public string CN_Address { get; set; }

    public virtual ICollection<Kho> Kho { get; set; } = new List<Kho>();

    public virtual ICollection<NhanVien> NhanVien { get; set; } = new List<NhanVien>();
}