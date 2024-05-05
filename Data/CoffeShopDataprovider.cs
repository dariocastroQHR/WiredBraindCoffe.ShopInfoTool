using WiredBraindCoffe.ShopInfoTool.Model;

namespace WiredBraindCoffe.ShopInfoTool.Data;

public class CoffeShopDataprovider
{
    public IEnumerable<CoffeShop> LoadShops()
    {
        return new CoffeShop[]
        {
            new CoffeShop("Tegu",45),
            new CoffeShop("SPS",39),
            new CoffeShop("Sigua",25),
             new CoffeShop("Copan",28)
        };
    }
}
