using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTUD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Thôngtinxe ttxe = null;
        Thôngtinthue ttthue = null;
        ThôngtinPN ttpn = null;
        ThôngtinPX ttpx = null;
        Thôngtinnv ttnv = null;
        ThongtinCTPN ttctpn = null;
        ThongtinCTPX ttctpx = null;
        ThongtinKM ttkm = null;
        BanHang bh = null;
        NhapHang nh = null;
        ThongtinKH ttkh = null;

        private void thôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ttxe == null||ttxe.IsDisposed)
            {
                ttxe = new Thôngtinxe();
                ttxe.Show();
                ttxe.MdiParent = this;
            }
            else
            {
                ttxe.BringToFront();
            }
        }

        private void thôngTinPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttthue == null || ttthue.IsDisposed)
            {
                ttthue = new Thôngtinthue();
                ttthue.Show();
                ttthue.MdiParent = this;
            }
            else
            {
                ttthue.BringToFront();
            }
        }

        private void thôngTinPhiêuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttpn == null || ttpn.IsDisposed)
            {
                ttpn = new ThôngtinPN();
                ttpn.Show();
                ttpn.MdiParent = this;
            }
            else
            {
                ttpn.BringToFront();
            }
        }

        private void thôngTinPhiêuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttpx == null || ttpx.IsDisposed)
            {
                ttpx = new ThôngtinPX();
                ttpx.Show();
                ttpx.MdiParent = this;
            }
            else
            {
                ttpx.BringToFront();
            }
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ttnv == null || ttnv.IsDisposed)
            {
                ttnv = new Thôngtinnv();
                ttnv.Show();
                ttnv.MdiParent = this;
            }
            else
            {
                ttnv.BringToFront();
            }
        }

        private void thôngTinCTPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttctpn == null || ttctpn.IsDisposed)
            {
                ttctpn = new ThongtinCTPN();
                ttctpn.Show();
                ttctpn.MdiParent = this;
            }
            else
            {
                ttctpn.BringToFront();
            }

        }

        private void thôngTinCTPXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttctpx == null || ttctpx.IsDisposed)
            {
                ttctpx = new ThongtinCTPX();
                ttctpx.Show();
                ttctpx.MdiParent = this;
            }
            else
            {
                ttctpx.BringToFront();
            }
        }

        private void thôngTinKMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttkm == null || ttkm.IsDisposed)
            {
                ttkm = new ThongtinKM();
                ttkm.Show();
                ttkm.MdiParent = this;
            }
            else
            {
                ttkm.BringToFront();
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bh == null || bh.IsDisposed)
            {
                bh = new BanHang();
                bh.Show();
                bh.MdiParent = this;
            }
            else
            {
                bh.BringToFront();
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nh == null || nh.IsDisposed)
            {
                nh = new NhapHang();
                nh.Show();
                nh.MdiParent = this;
            }
            else
            {
                nh.BringToFront();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttkh == null || ttkh.IsDisposed)
            {
                ttkh = new ThongtinKH();
                ttkh.Show();
                ttkh.MdiParent = this;
            }
            else
            {
                ttkh.BringToFront();
            }
        }
    }
}
