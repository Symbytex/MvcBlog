﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class MessageAuthor
    {
        [Key]
        public int MessageAuthorID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
      
        public bool ContactStatus { get; set; }
        public int AuthorID { get; set; }                                      
        

    }
}