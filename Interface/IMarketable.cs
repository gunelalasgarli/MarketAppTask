using SecondConsoleApp.Enum;
using SecondConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Interface
{
    interface IMarketable
    {
        //       IMarketable

        //- Satislar
        //- Mehsullar
        //- Satis elave etmek - satis elave edilerken hansi mehsullardan hansi sayda satis oldugu gonderilir
        //- Satisdan mehsulun geri qaytarilmasi
        //- Umumi satisin geri qaytarilmasi
        //- Verilen tarix araligina gore hemin tarix araligina olan satislarin qaytarilmasi
        //- Verilen bir tarixe gore hemin tarix(il, ay, gun) ucun olan satislarin qaytarilmasi
        //- Verilmis mebleg araligina gore edilmis satislarin qaytarilmasi
        //- Verilmis nomreye esasen satisin qaytarilmasi
        //- Yeni mehsul elave etmek
        //- Mehsulun adini, sayini ve meblegini, categoriyasini deyismek(code-a gore tapilacaq)
        //- Verilmis kateqoriyaya esasen hemin kateqoriyada olan mehsullarin qaytarilmasi
        //- Verilmis qiymet araligina esasen hemin araliqda olan mehsullarin qaytarilmasi
        //- Verilmis ada esasen mehsullarin search edilib qaytarilmasi

        List<Product> Products { get; set; }
        List<Sell> SoldProduct { get; set; }
        void SellItem(int sellitemno, Product sellitemproduct, int count);
        void AddProduct(string name, double price, Category category, string code);
        void AddSell(int SellNo, double Amount, string datetime, SellItem sellItem);
        void GetSell(int SellNo, SellItem sellItem);
        //void Sell(byte startday, byte month, int year, List<Product> SoldProduct);


    }
}
