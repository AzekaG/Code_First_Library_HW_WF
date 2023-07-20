using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipEF_LoadingDb_18._07_WF.Model
{
     class ProductionHouse
    {
        public int Id { get; set; } 
        
        [Required] 
        [StringLength(50)]
        public string Name { get; set; }


        public virtual ICollection<Book> Books { get; set; }

        public ProductionHouse() 
        { 
             Books = new HashSet<Book>();
        }


    }
}
