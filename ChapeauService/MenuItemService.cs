using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class MenuItemService
    {
        private MenuItemDao menuItemDb;

        public MenuItemService()
        {
            menuItemDb = new MenuItemDao();
        }

        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = menuItemDb.GetAllMenuItems();

            return menuItems;
        }
    }
}