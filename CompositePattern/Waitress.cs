namespace CompositePattern
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void Print()
        {
            _allMenus.Print();
        }
    }
}
