using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace WebBanNhomKinh.Models
{
    public class QuanLyHangSX
    {
        public IPagedList<HangSanXuat> DanhSachHangSanXuat { get; set; }
        public HangSanXuat HangSanXuat { get; set; }
    }
}