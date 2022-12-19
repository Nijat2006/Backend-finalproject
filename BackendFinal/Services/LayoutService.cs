using BackendFinal.DAL;
using BackendFinal.interfaces;
using BackendFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal.Services
{
    public class LayoutServices : ILayoutService
    {
        private readonly AppDbContext _context;
        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }

        public Task<Dictionary<string, string>> GetSettingAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Dictionary<string, string>> GetSettingsAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }



    }

}

