﻿using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        
        public List<Departament> FindAll() /*Retorna todos departamentos*/
        {
            return _context.Departament.OrderBy(x => x.Name).ToList(); 
            /*OrderBy faz parte do linq, ordenando os departamentos por nome*/
        }
    }
}
