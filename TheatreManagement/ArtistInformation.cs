using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreManagement
{
    public partial class ArtistInformation : Form
    {
        List<ArtistViewModel> _list;
        public ArtistInformation(List<ArtistViewModel> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void ArtistInformation_Load(object sender, EventArgs e)
        {
            ArtistInfo rpt = new ArtistInfo();
            rpt.SetDataSource(_list);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }
    }
}
