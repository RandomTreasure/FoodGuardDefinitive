using FoodGuardDefinitive.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodGuardDefinitive
{
   // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            #region Routing

            Routing.RegisterRoute(nameof(RecapPage), typeof(RecapPage));
            Routing.RegisterRoute(nameof(InventoryPage), typeof(InventoryPage));
            Routing.RegisterRoute(nameof(ShoppingListPage), typeof(ShoppingListPage));
            Routing.RegisterRoute(nameof(ExpiringSoonPage), typeof(ExpiringSoonPage));
            Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));

            #endregion

            //Routing.RegisterRoute(nameof(), typeof());


            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}