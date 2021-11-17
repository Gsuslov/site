using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockFish : IFish       
        
    {
        private readonly IRiver _RiverFish = new MockRiver();
        public IEnumerable<Fish> GetFishId
        {
            get
            {
                return new List<Fish> {
                    new Fish {id = 434 },
                new Fish {img = "https://yandex.ru/images/search?pos=0&from=tabbar&img_url=https%3A%2F%2Fgetwallpapers.com%2Fwallpaper%2Ffull%2Fe%2F8%2Fa%2F1106989-amazing-red-nature-wallpaper-2880x1800-samsung.jpg&text=картинки&rpt=simage" }
                };

            }
        }
    }

}

