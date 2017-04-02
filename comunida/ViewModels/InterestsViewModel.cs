using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using comunida.Models;

namespace comunida.ViewModels
{
    public class InterestsViewModel
    {
        //public List<string> Interests { get; set; }
        //public MultiSelectList InterestsList { get; private set; }
        public int[] SelectedIds { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }
    }
}
