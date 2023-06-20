using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoMo
{
    public static class StackNavigation
    {
        public static Stack<Form> ScreenStack = new Stack<Form>();

        public static void Push(Form screen)
        {
            if (ScreenStack.Count > 0)
            {
                Form previousScreen = ScreenStack.Peek();
                previousScreen.Hide();
            }

            screen.Show();
            ScreenStack.Push(screen);
        }

        public static void Pop()
        {
            Form screen = ScreenStack.Pop();
            screen.Close();

            if(ScreenStack.Count == 0)
                return;

            Form previousScreen = ScreenStack.Peek();
            if (previousScreen.Name == "Screen")
                ((Screen)previousScreen).RefreshScreen();
            previousScreen.Show();
        }

        public static void Clear()
        {
            ScreenStack.Clear();
        }
    }
}
