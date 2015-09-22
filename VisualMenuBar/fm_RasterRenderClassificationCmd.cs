using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;

namespace VisualMenuBar
{
    class fm_RasterRenderClassificationCmd : MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;

        public fm_RasterRenderClassificationCmd()
        {
            string str = @"..\Data\Image\VisualMenuBar\fm_RasterRenderClassificationCmd.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }

        #region ICommand 成员

        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "栅格渲染分级"; }
        }

        public string Category
        {
            get { return "栅格渲染"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "栅格渲染分级"; }
        }

        public string Name
        {
            get { return "fm_RasterRenderClassificationCmd"; }
        }

        public void OnClick()
        {
            if (this.hk == null) return;
            if (this.hk.MapControl.Map.LayerCount > 0)
            {
                fm_RasterRenderClassification RasterRenderClassification = new fm_RasterRenderClassification(this.hk);
                RasterRenderClassification.Show(this.hk as System.Windows.Forms.IWin32Window);
            }
        }

        public void OnCreate(MyPluginEngine.IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
  
            }
        }

        public string Tooltip
        {
            get { return "栅格渲染分级"; }
        }

        #endregion
    }
}
