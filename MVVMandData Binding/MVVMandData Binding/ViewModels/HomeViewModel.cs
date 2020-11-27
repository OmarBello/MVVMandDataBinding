using MVVMandDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMandDataBinding.ViewModels
{
    public class HomeViewModel : MenuOptions
    {
        public MenuOptions BarAndHotelsMenuOption { get; set; } = new MenuOptions();
        public MenuOptions FineDiningMenuOption { get; set; } = new MenuOptions();
        public MenuOptions CafesMenuOption { get; set; } = new MenuOptions();
        public MenuOptions NearbyMenuOption { get; set; } = new MenuOptions();
        public MenuOptions FastFoodsMenuOption { get; set; } = new MenuOptions();
        public MenuOptions FeaturedFoodsMenuOption { get; set; } = new MenuOptions();
        public HomeViewModel()
        {
            BarAndHotelsMenuOption.Title = "Bar and Hotels";
            FineDiningMenuOption.Title = "Fine Dining";
            CafesMenuOption.Title = "Cafes";
            NearbyMenuOption.Title = "Nearby";
            FastFoodsMenuOption.Title = "FastFoods";
            FeaturedFoodsMenuOption.Title = "Featured Foods";
        }
    }
}
