﻿using IntegrationLibrary.Features.BloodRequests.Model;
using IntegrationLibrary.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegrationLibrary.Features.BloodRequests.Repository
{
    public class BloodRequestRepository : IBloodRequestRepository
    {
        private readonly IntegrationDbContext _context;
        public BloodRequestRepository(IntegrationDbContext context)
        {
            _context = context;
        }
        public void Create(BloodRequest bloodRequest)
        {
            _context.BloodRequests.Add(bloodRequest);
            _context.SaveChanges();
        }

        public IEnumerable<BloodRequest> GetAll()
        {
            return _context.BloodRequests.ToList();
        }

        public BloodRequest GetById(int id)
        {
            return _context.BloodRequests.Find(id);
        }
    }
}
