﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI_QLKH.Models;

public partial class DonNhap
{
    public string DNhap_ID { get; set; }

    public string NCC_ID { get; set; }

    public DateTime DN_Datetime { get; set; }

    public string DN_Name { get; set; }

    public string NV_ID { get; set; }

    public virtual ChiTietDonNhap ChiTietDonNhap { get; set; }

    public virtual NCC NCC { get; set; }

    public virtual NhanVien NV { get; set; }
}