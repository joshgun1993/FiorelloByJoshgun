using Fiorello.Models;
using System.Collections.Generic;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderData SliderData { get; set; }
        public About About { get; set; }
        public List<AboutList> AboutLists { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Info> Infos { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories{ get; set; }

    }
}
