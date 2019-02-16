using System.Collections.Generic;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CiuchApp.Dashboard.Extensions.ViewComponents
{
    public class DropdownViewModel
    {
        public Piece Model { get; internal set; }
        public string FieldLabel { get; internal set; }
        public string Field { get; internal set; }
        public IEnumerable<SelectListItem> Values { get; internal set; }
    }
}