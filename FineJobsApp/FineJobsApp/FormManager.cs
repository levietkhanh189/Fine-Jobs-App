using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineJobsApp
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public static class FormManager
    {
        private static readonly Dictionary<Type, Form> forms = new Dictionary<Type, Form>();

        public static T GetForm<T>() where T : Form, new()
        {
            Type type = typeof(T);
            if (forms.ContainsKey(type) && !forms[type].IsDisposed)
            {
                return forms[type] as T;
            }
            else
            {
                T form = new T();
                form.FormClosed += (s, args) => forms.Remove(type);
                forms[type] = form;
                return form;
            }
        }

        public static void ShowForm<T>() where T : Form, new()
        {
            Form form = GetForm<T>();
            form.Show();
            form.BringToFront();
        }

        public static void HideForm<T>() where T : Form, new()
        {
            Type type = typeof(T);
            if (forms.ContainsKey(type) && forms[type].Visible)
            {
                forms[type].Hide();
            }
        }
    }

}
