using System.Windows.Forms;
using Phonizer.Forms;

namespace Phonizer.Static
{
    public static class Context
    {
        public static int CurrentMaxId { get; set; }

        public static LoginForm LoginForm { get; set; }

        public static  DataGridView CallsDataGridView { get; set; }
    }
}