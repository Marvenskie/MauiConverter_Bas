using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiConverter_Bas.Model
{
    public class projModel
    {
        public string Name { get; set; }
        public string Icon { get; set; } 
        public string NavigationTarget { get; set; } 
        public Color BackgroundColor { get; set; } = Color.FromArgb("#320E60");
    }
}
