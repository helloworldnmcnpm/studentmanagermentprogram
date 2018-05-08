using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Mark : UserControl
    {
        private static Mark _instance;
        public static Mark Instance
        {
            get
            {
                if (_instance == null) _instance=new Mark();
                return _instance;
            }
        }
        public Mark()
        {
            InitializeComponent();
        }

        private void ButtonAddScore_Click(object sender, EventArgs e)
        {
            if (!Activities.Controls.Contains(AddScore.Instance))
            {
                Activities.Controls.Add(AddScore.Instance);
                AddScore.Instance.Dock = DockStyle.Fill;
                AddScore.Instance.BringToFront();
            }
            else AddScore.Instance.BringToFront();
        }

        private void Mark_Load(object sender, EventArgs e)
        {

        }
    }
}
