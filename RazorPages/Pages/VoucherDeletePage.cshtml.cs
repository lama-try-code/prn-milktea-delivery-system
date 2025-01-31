﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using BusinessObject.Entities;
using Repositories.Voucher;

namespace RazorPages.Pages
{
    public class DeleteVoucherModel(IVoucherRepository _voucherRepository) : PageModel
    {

        [BindProperty]
        public BusinessObject.Entities.Voucher Voucher { get; set; }
        [BindProperty]
        public string Msg { get; set; }

        public void OnGetAsync(string id)
        {
            Voucher = _voucherRepository.GetVoucher(id);
        }

        public void OnPostAsync(string id)
        {
            Msg = _voucherRepository.Delete(id);
        }
    }
}
