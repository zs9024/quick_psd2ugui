using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace PSDUIImporter
{
    internal class InputFieldLayerImport : ILayerImport
    {
        private PSDImportCtrl pSDImportCtrl;

        public InputFieldLayerImport(PSDImportCtrl pSDImportCtrl)
        {
            this.pSDImportCtrl = pSDImportCtrl;
        }

        public void DrawLayer(Layer layer, GameObject parent)
        {
            UnityEngine.UI.InputField temp = AssetDatabase.LoadAssetAtPath(PSDImporterConst.ASSET_PATH_INPUTFIELD, typeof(UnityEngine.UI.InputField)) as UnityEngine.UI.InputField;
            UnityEngine.UI.InputField inputfield = GameObject.Instantiate(temp) as UnityEngine.UI.InputField;
            inputfield.transform.SetParent(parent.transform, false);//.parent = parent.transform;
            inputfield.name = layer.name;

            // 背景尺寸,用来限制文本框尺寸
            float _bgSize = 0;

            for (int i = 0; i < layer.layers.Length; ++i)
            {
                var _temp = layer.layers[i];

                if (_temp.image != null)
                {
                    //for (int imageIndex = 0; imageIndex < layer.images.Length; imageIndex++)
                    //{
                    PSImage image = _temp.image;

                    if (image.imageType == ImageType.Label)
                    {
                        if (image.name.ToLower().Contains("text"))
                        {
                            this.pSDImportCtrl.DrawLayer(_temp, inputfield.gameObject);

                            var _text = PSDImportUtility.canvas.transform.Find(_temp.name).GetComponent<Text>();

                            RectTransform _rectTransform = _text.GetComponent<RectTransform>();

                            // 需要重设锚点,目前默认left
                            var _offsetMin = _rectTransform.offsetMin;
                            var _offsetMax = _rectTransform.offsetMax;

                            _rectTransform.pivot = new Vector2(0, 1);

                            _rectTransform.offsetMin = _offsetMin;
                            _rectTransform.offsetMax = _offsetMax;

                            if (Math.Abs(_bgSize) < float.Epsilon)
                            {
                                for (int j = 0; j < layer.layers.Length; ++j)
                                {
                                    var _layerLayer = layer.layers[i];

                                    if (_layerLayer.image != null)
                                    {
                                        if (_layerLayer.image.imageType != ImageType.Label &&
                                            _layerLayer.image.name.Contains("background"))
                                        {
                                            _bgSize = _layerLayer.image.size.width;

                                            break;
                                        }
                                    }
                                }
                            }

                            if (_rectTransform.sizeDelta.x < _bgSize)
                            {
                                _rectTransform.sizeDelta = new Vector2(_bgSize, _rectTransform.sizeDelta.y);
                            }

                            _text.supportRichText = false;
                            _text.text = "";

                            if (inputfield.textComponent != null)
                            {
                                Object.DestroyImmediate(inputfield.textComponent.gameObject);
                            }

                            inputfield.textComponent = _text;

                            //UnityEngine.UI.Text text = (UnityEngine.UI.Text)inputfield.textComponent;//inputfield.transform.Find("Text").GetComponent<UnityEngine.UI.Text>();
                            //Color color;
                            //if (UnityEngine.ColorUtility.TryParseHtmlString(("#" + image.arguments[0]), out color))
                            //{
                            //    text.color = color;
                            //}

                            //int size;
                            //if (int.TryParse(image.arguments[2], out size))
                            //{
                            //    text.fontSize = size;
                            //}
                        }
                        else if (image.name.ToLower().Contains("holder"))
                        {
                            this.pSDImportCtrl.DrawLayer(_temp, inputfield.gameObject);

                            if (inputfield.placeholder != null)
                            {
                                Object.DestroyImmediate(inputfield.placeholder.gameObject);
                            }

                            inputfield.placeholder = PSDImportUtility.canvas.transform.Find(_temp.name).GetComponent<Text>();
                            ((Text)inputfield.placeholder).supportRichText = false;

                            //UnityEngine.UI.Text text = (UnityEngine.UI.Text)inputfield.placeholder;//.transform.Find("Placeholder").GetComponent<UnityEngine.UI.Text>();
                            //Color color;
                            //if (UnityEngine.ColorUtility.TryParseHtmlString(("#" + image.arguments[0]), out color))
                            //{
                            //    text.color = color;
                            //}

                            //int size;
                            //if (int.TryParse(image.arguments[2], out size))
                            //{
                            //    text.fontSize = size;
                            //}
                        }
                    }
                    else
                    {
                        if (image.name.ToLower().Contains("background"))
                        {
                            if (image.imageSource == ImageSource.Common || image.imageSource == ImageSource.Custom)
                            {
                                string assetPath = PSDImportUtility.baseDirectory + image.name + PSDImporterConst.PNG_SUFFIX;
                                Sprite sprite = AssetDatabase.LoadAssetAtPath(assetPath, typeof(Sprite)) as Sprite;
                                inputfield.image.sprite = sprite;

                                RectTransform rectTransform = inputfield.GetComponent<RectTransform>();
                                rectTransform.sizeDelta = new Vector2(image.size.width, image.size.height);
                                _bgSize = image.size.width;

                                rectTransform.anchoredPosition = new Vector2(image.position.x, image.position.y);
                            }
                        }
                    }
                    //}
                }
            }

            //if (layer.image != null)
            //{
            //    //for (int imageIndex = 0; imageIndex < layer.images.Length; imageIndex++)
            //    //{
            //        PSImage image = layer.image;

            //        if (image.imageType == ImageType.Label)
            //        {
            //            if (image.name.ToLower().Contains("text"))
            //            {
            //                UnityEngine.UI.Text text = (UnityEngine.UI.Text)inputfield.textComponent;//inputfield.transform.Find("Text").GetComponent<UnityEngine.UI.Text>();
            //                Color color;
            //                if (UnityEngine.ColorUtility.TryParseHtmlString(("#" + image.arguments[0]), out color))
            //                {
            //                    text.color = color;
            //                }

            //                int size;
            //                if (int.TryParse(image.arguments[2], out size))
            //                {
            //                    text.fontSize = size;
            //                }
            //            }
            //            else if (image.name.ToLower().Contains("holder"))
            //            {
            //                UnityEngine.UI.Text text = (UnityEngine.UI.Text)inputfield.placeholder;//.transform.Find("Placeholder").GetComponent<UnityEngine.UI.Text>();
            //                Color color;
            //                if (UnityEngine.ColorUtility.TryParseHtmlString(("#" + image.arguments[0]), out color))
            //                {
            //                    text.color = color;
            //                }

            //                int size;
            //                if (int.TryParse(image.arguments[2], out size))
            //                {
            //                    text.fontSize = size;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (image.name.ToLower().Contains("background"))
            //            {
            //                if (image.imageSource == ImageSource.Common || image.imageSource == ImageSource.Custom)
            //                {
            //                    string assetPath = PSDImportUtility.baseDirectory + image.name + PSDImporterConst.PNG_SUFFIX;
            //                    Sprite sprite = AssetDatabase.LoadAssetAtPath(assetPath, typeof(Sprite)) as Sprite;
            //                    inputfield.image.sprite = sprite;

            //                    RectTransform rectTransform = inputfield.GetComponent<RectTransform>();
            //                    rectTransform.sizeDelta = new Vector2(image.size.width, image.size.height);
            //                    rectTransform.anchoredPosition = new Vector2(image.position.x, image.position.y);
            //                }
            //            }
            //        }
            //    //}
            //}
        }
    }
}