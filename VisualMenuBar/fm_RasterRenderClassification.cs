using cbbColor;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualMenuBar
{
    public partial class fm_RasterRenderClassification : DevComponents.DotNetBar.OfficeForm
    {
        IMap m_map = null;  

        //设置分级选择参数
        public IRasterLayer rasterlayer;
        ColorStyle style = new ColorStyle();
        List<IColorRamp> pListRamp = new List<IColorRamp>();
        public IMapControlDefault axmapcontrol;
        public ITOCControlDefault axtoccontrol;
        string[] classmethod = new string[] { "自然断点分级", "等间距分级" };
        int[] classcount = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


        public fm_RasterRenderClassification(MyPluginEngine.IApplication hook)
        {
            InitializeComponent();
            //禁用Glass主题
            this.EnableGlass = false;
            //不显示最大化最小化按钮
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //去除图标
            this.ShowIcon = false;

            
            m_map = hook.MapControl.Map;
            axtoccontrol = hook.TOCControl;
            axmapcontrol = hook.MapControl;
            
        }
        private void CbxLayersAddItems()
        {
            if (GetLayers() != null)
            {
                IEnumLayer layers = GetLayers();
                layers.Reset();
                ILayer layer = layers.Next();
                while (layer != null)
                {
                    if (layer is IRasterLayer)
                    {
                        rasterlayer = layer as IRasterLayer;
                        cbb_RasterLayersStretch.Items.Add(layer.Name);
                        cbb_RasterLayersScale.Items.Add(layer.Name);
                    }
                    layer = layers.Next();
                }
            }
        }
        #region "GetLayers"
        private IEnumLayer GetLayers()
        {
            UID uid = new UIDClass();
            //IRasterLayer pRasterLayer = new RasterLayerClass();
            //uid.Value = pRasterLayer.GetType().GUID;
            uid.Value = "{D02371C7-35F7-11D2-B1F2-00C04F8EDEFF}";
            if (m_map.LayerCount != 0)
            {
                IEnumLayer layers = m_map.get_Layers(uid, true);
                return layers;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region "GetRasterLayer"
        private IRasterLayer GetRasterLayer(string layerName)
        {
            //get the layers from the maps
            if (GetLayers() == null)
            {
                return null;
            }
            else
            {
                IEnumLayer layers = GetLayers();
                layers.Reset();

                ILayer layer = null;
                while ((layer = layers.Next()) != null)
                {
                    if (layer.Name == layerName)
                        return layer as IRasterLayer;
                }
                return null;
            }

        }

        #endregion

        private void fm_RasterRenderClassification_Load(object sender, EventArgs e)
        {
            CbxLayersAddItems();
            
            if (cbb_RasterLayersStretch.Items.Count != 0)
            {
                cbb_RasterLayersStretch.SelectedIndex = 0;
                cbb_RasterLayersScale.SelectedIndex = 0;
                rasterlayer = GetRasterLayer(cbb_RasterLayersStretch.SelectedItem.ToString());
                cbb_BandStretch.DataSource = RasterRender.getBandName(rasterlayer);
            }

            List<ComboBoxSym> list3 = new List<ComboBoxSym>();
            list3.Add(cbbs_ColorStretch);
            list3.Add(cbbs_ColorStretch2);
            style.Style("Color Ramps", list3);
            List<ComboBoxSym> list4 = new List<ComboBoxSym>();
            list4.Add(cbbs_ColorScale);
            list4.Add(cbbs_ColorScale2);
            style.Style("Color Ramps", list4);
            cbb_NumberScale.DataSource = classcount;
            cbb_MethodScale.DataSource = classmethod;
            cbbs_ColorStretch.SelectedIndex = 0;
            cbbs_ColorStretch2.SelectedIndex = 0;
            cbbs_ColorScale.SelectedIndex = 0;
            cbbs_ColorScale2.SelectedIndex = 0;
            cbb_MethodScale.SelectedIndex = 0;
            cbb_NumberScale.SelectedIndex = 0;
        }

        private void cbb_RasterLayersStretch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_RasterLayersStretch.SelectedItem != null)
            {
                string RasterName = cbb_RasterLayersStretch.SelectedItem.ToString();
                rasterlayer = GetRasterLayer(RasterName);
               
                cbb_BandStretch.DataSource = RasterRender.getBandName(rasterlayer);
            }
        }

        private void btn_OkStretch_Click(object sender, EventArgs e)
        {
            try
            {
                string RasterName = cbb_RasterLayersStretch.SelectedItem.ToString();
                rasterlayer = GetRasterLayer(RasterName);
                IRasterStretchColorRampRenderer rasStreRen = new RasterStretchColorRampRendererClass();
                IRasterRenderer rasRen = rasStreRen as IRasterRenderer;
                rasRen.Raster = rasterlayer.Raster;
                rasRen.Update();
                rasStreRen.BandIndex = cbb_BandStretch.SelectedIndex;
                pListRamp = style.pListRamp;
                rasStreRen.ColorRamp = (IColorRamp)pListRamp[cbbs_ColorStretch.SelectedIndex];
                rasRen.Update();
                rasterlayer.Renderer = rasStreRen as IRasterRenderer;
                IRasterStretch2 stretch = rasStreRen as IRasterStretch2;
                stretch.BackgroundValue = 0;
                stretch.Background = true;
                stretch.BackgroundColor = RasterRender.GET(255, 255, 255) as IColor;
                axmapcontrol.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                axtoccontrol.Update();
                axmapcontrol.Extent = rasterlayer.AreaOfInterest;
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btn_OkScale_Click(object sender, EventArgs e)
        {
            try
            {
                string RasterName = cbb_RasterLayersStretch.SelectedItem.ToString();
                rasterlayer = GetRasterLayer(RasterName);
                RasterRender render = new RasterRender();
                pListRamp = style.pListRamp;
                render.RasterClassify(rasterlayer, cbb_MethodScale.SelectedValue.ToString(), Convert.ToInt32(cbb_NumberScale.SelectedValue), (IColorRamp)pListRamp[cbbs_ColorScale.SelectedIndex]);
                axmapcontrol.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                axtoccontrol.Update();
                axmapcontrol.Extent = rasterlayer.AreaOfInterest;
                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
