using ConsoleApplication1.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Windows
{
    public abstract class Window
    {
        protected Application _application;

        protected List<Component> _components = new List<Component>();

        public Window(Application app)
        {
            this._application = app;
        }

        public void OnKey(ConsoleKeyInfo info)
        {
            if (info.Key == ConsoleKey.Enter)
            {
                Window next = this.OnSubmit();
                this._application.SwitchWindow(next);
            }
            else if (info.Key == ConsoleKey.Escape)
            {
                Window next = this.OnEscape();
                this._application.SwitchWindow(next);
            }
            else if (info.Key == ConsoleKey.Tab)
            {
                this.RotateActiveComponents();
            }
            else
            {
                this.ActiveComponent().OnKey(info);
            }
        }

        private void RotateActiveComponents()
        {
            int activeIndex = 0;
            int i = 0;
            foreach (Component item in this._components)
            {
                if (item.Active)
                    activeIndex = i;

                item.Active = false;
                i++;
            }

            this._components[(activeIndex + 1) % this._components.Count].Active = true;
        }

        public void Render()
        {
            foreach (Component item in this._components)
            {
                item.Render();
            }
        }

        protected Component ActiveComponent()
        {
            foreach (Component item in this._components)
            {
                if (item.Active)
                    return item;
            }

            throw new InvalidOperationException("No active component");
        }

        protected abstract Window OnSubmit();

        protected abstract Window OnEscape();
    }
}
