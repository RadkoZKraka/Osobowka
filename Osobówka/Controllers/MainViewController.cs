using System.Windows.Forms;

namespace Osobówka
{
    public partial class MainViewController : UserControl
    {
        public MainViewController()
        {
            var inputsPanel = new InputsViewController();
            var dataPanel = new DataViewController();
            
            InitializeComponent();
            
            inputsPanel.Dock = DockStyle.Right;
            dataPanel.Dock = DockStyle.Left;
            
            Controls.Add(inputsPanel);
            Controls.Add(dataPanel);
        }
    }
}