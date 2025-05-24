using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKart.ViewModels.DegreeProgramViewModels
{
    public class EditDegreeProgramViewModel
    {
        public int DegreeProgramId { get; set; }

        public CreateDegreeProgramViewModel DegreeProgramViewModel { get; set; }
    }
}
