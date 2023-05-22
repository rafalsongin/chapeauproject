using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class MenuService
    {
        private MenuDao menuDb;

        public MenuService()
        {
            menuDb = new MenuDao();
        }

        public List<Menu> GetMenus()
        {
            List<Menu> menus = menuDb.GetAllMenus();

            return menus;
        }
    }
}