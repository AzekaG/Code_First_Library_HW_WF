using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipEF_LoadingDb_18._07_WF.Model
{
     class Book
    {
        public int Id {  get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
       
        public int AmountPages { get; set; }

        public Book() { }
        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }

        public virtual ProductionHouse ProductionHouse { get; set; }

        public override string ToString()
        {
            return Name + " " + AmountPages;
        }



    }
}
