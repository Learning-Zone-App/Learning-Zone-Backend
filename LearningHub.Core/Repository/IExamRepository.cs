﻿using LearningHub.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.Core.Repository
{
    public interface IExamRepository
    {
        List<Examsection> CreateExam(Examsection examsection);
        List<Examsection> GetExamByCourseId(int id);
    }
}