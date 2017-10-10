using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using Quick.UI;
using UnityEngine.UI;

namespace PSDUIImporter
{
    /// <summary>
    /// 自定义页签组件的生成
    /// </summary>
    public class TabGroupLayerImport : ILayerImport
    {
        PSDImportCtrl ctrl;
        public TabGroupLayerImport(PSDImportCtrl ctrl)
        {
            this.ctrl = ctrl;
        }
        public void DrawLayer(Layer layer, GameObject parent)
        {
            TabGroup tabGroup = PSDImportUtility.LoadAndInstant<TabGroup>(PSDImporterConst.ASSET_PATH_TABGROUP, layer.name, parent);

            if (layer.layers == null)
            {
                Debug.LogError("error! bad tabgroup layers.");
                return;
            }

            for (int index = 0; index < layer.layers.Length; index++)
            {
                Layer subLayer = layer.layers[index];
                string layerName = subLayer.name;           //Shop_Tab:Shop
                if(layerName.ToLower().Contains("_tab"))
                {
                    Tab tab = ImportTabLayer(subLayer, tabGroup.gameObject);
                    tab.group = tabGroup;
                }
                else
                {
                    ctrl.DrawLayer(subLayer, tabGroup.gameObject);
                }
            }
        }

        private Tab ImportTabLayer(Layer layer, GameObject parent)
        {
            string tabName = layer.name.Substring(0, layer.name.IndexOf("_Tab"));
            string tag = layer.name.LastIndexOf(':') == -1 ? tabName : layer.name.Substring(layer.name.LastIndexOf(':') + 1);
            //Debug.LogWarning("tab name = " + tabName + "  tab tag = " + tag);

            Tab tab = PSDImportUtility.LoadAndInstant<Tab>(PSDImporterConst.ASSET_PATH_TAB, tabName, parent);
            tab.tag = tag;

            if (layer.layers == null)
            {
                Debug.LogError("error! bad tab layers.");
                return null;
            }

            for (int index = 0; index < layer.layers.Length; index++)
            {
                Layer subLayer = layer.layers[index];
                PSImage image = subLayer.image;
                if (image != null)
                {
                    string lowerName = image.name.ToLower();
                    if (lowerName.Contains("_tabsel"))
                    {
                        ctrl.DrawImage(image, tab.gameObject, tab.graphic.gameObject);
                    }
                    else if (lowerName.Contains("_tabunsel"))
                    {
                        ctrl.DrawImage(image, tab.gameObject, tab.targetGraphic.gameObject);
                    }
                    else
                    {
                        ctrl.DrawImage(image, tab.gameObject);
                    }
                }
                else
                {
                    if (subLayer.name.ToLower().Contains("_page"))
                    {
                        string name = subLayer.name.Substring(0, subLayer.name.Length - 5);
                        tab.page.gameObject.name = name;
                        ctrl.DrawLayers(subLayer.layers, tab.page.gameObject);      //跳过page层，只绘制子
                    }
                    else
                    {
                        ctrl.DrawLayer(subLayer, tab.gameObject);
                    }
                }
            }

            return tab;
        }

    }
}