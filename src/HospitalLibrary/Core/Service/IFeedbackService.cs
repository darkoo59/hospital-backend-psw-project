﻿using HospitalLibrary.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.Core.Service
{
    public interface IFeedbackService
    {
        IEnumerable<Feedback> GetAll();
        Feedback GetById(int id);
        void Create(Feedback feedback);
        void Update(Feedback feedback);
        void Delete(Feedback feedback);
    }
}
