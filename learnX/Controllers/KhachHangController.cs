using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using learnX.Models;

namespace learnX.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly IKhachHangService khachhangService;
        private readonly IMapper mapper;
       

        public KhachHangController(IKhachHangService khachhangService, IMapper mapper)
        {
            this.khachhangService = khachhangService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(khachhangService.GetKhachHangs());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            KhachHangViewModel data = new KhachHangViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (id != 0)
            {
                KhachHang res = khachhangService.GetKhachHang(id);
                data = mapper.Map<KhachHangViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, KhachHangViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (ModelState.IsValid)
            {
                try
                {
                    KhachHang res = mapper.Map<KhachHang>(data);
                    if (id != 0)
                    {
                        khachhangService.UpdateKhachHang(res);
                    }
                    else
                    {
                        khachhangService.InsertKhachHang(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "KhachHang");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            KhachHang res = khachhangService.GetKhachHang(id);
            khachhangService.DeleteKhachHang(res);

            return RedirectToAction("Index", "KhachHang");
        }
    }
}
