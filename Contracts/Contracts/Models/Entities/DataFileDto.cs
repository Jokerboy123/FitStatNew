﻿using Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class DataFileDto: DataFileDtoBase
    {
        
            
        /// <summary>
        /// Содержание
        /// </summary>
        public byte[] FileContent { get; set; }
         
      
    }
}