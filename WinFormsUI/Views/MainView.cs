using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsUI.Views.Abstract;

namespace WinFormsUI.Views
{
    public partial class MainView : Form , IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler CheckConfig;

        public new void Show()
        {
            Application.Run(this);
        }

        public void SetDetailData(List<BaseModel> details)
        {
            
        }
    }
}
