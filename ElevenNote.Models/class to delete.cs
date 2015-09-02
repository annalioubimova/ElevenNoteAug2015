using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
   public class Ok_to_delete


    {
        
        [Key]
        public int Id { get; set; }
        public String SomeColum { get; set; }
        public String Auri { get; set; }
        public String CarPolish { get; set; }

    }


}
