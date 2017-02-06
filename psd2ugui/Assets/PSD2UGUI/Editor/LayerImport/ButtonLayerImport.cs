using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


namespace PSDUIImporter
{
    public class ButtonLayerImport : ILayerImport
    {
        PSDImportCtrl ctrl;
        public ButtonLayerImport(PSDImportCtrl ctrl)
        {
            this.ctrl = ctrl;
        }

        public void DrawLayer(Layer layer, GameObject parent)
        {
            UnityEngine.UI.Button button = PSDImportUtility.LoadAndInstant<UnityEngine.UI.Button>(PSDImporterConst.ASSET_PATH_BUTTON, layer.name, parent);

            if (layer.layers != null)
            {
                for (int imageIndex = 0; imageIndex < layer.layers.Length; imageIndex++)
                {
                    PSImage image = layer.layers[imageIndex].image;
                    string lowerName = image.name.ToLower();
                    if (image.imageType == ImageType.Image && image.name.ToLower().Contains("normal") || image.name.ToLower().Contains("pressed") || image.name.ToLower().Contains("disabled") || image.name.ToLower().Contains("highlighted"))
                    {
                        if (image.imageSource == ImageSource.Custom || image.imageSource == ImageSource.Common)
                        {
                            string assetPath = PSDImportUtility.baseDirectory + image.name + PSDImporterConst.PNG_SUFFIX;
                            Sprite sprite = AssetDatabase.LoadAssetAtPath(assetPath, typeof(Sprite)) as Sprite;

                            if (image.name.ToLower().Contains("normal"))
                            {
                                button.image.sprite = sprite;

                                RectTransform rectTransform = button.GetComponent<RectTransform>();
                                rectTransform.sizeDelta = new Vector2(image.size.width, image.size.height);
                                rectTransform.anchoredPosition = new Vector2(image.position.x, image.position.y);

                                //rectTransform.SetParent(parent.transform, true);

                                //PosLoader posloader = button.gameObject.AddComponent<PosLoader>();
                                //posloader.worldPos = rectTransform.position;
                            }
                            else if (image.name.ToLower().Contains("pressed"))
                            {
                                button.transition = UnityEngine.UI.Selectable.Transition.SpriteSwap;
                                UnityEngine.UI.SpriteState state = button.spriteState;
                                state.pressedSprite = sprite;
                                button.spriteState = state;
                            }
                            else if (image.name.ToLower().Contains("disabled"))
                            {
                                button.transition = UnityEngine.UI.Selectable.Transition.SpriteSwap;
                                UnityEngine.UI.SpriteState state = button.spriteState;
                                state.disabledSprite = sprite;
                                button.spriteState = state;
                            }
                            else if (image.name.ToLower().Contains("highlighted"))
                            {
                                button.transition = UnityEngine.UI.Selectable.Transition.SpriteSwap;
                                UnityEngine.UI.SpriteState state = button.spriteState;
                                state.highlightedSprite = sprite;
                                button.spriteState = state;
                            }
                        }
                    }
                    else
                    {
                        //ctrl.DrawImage(image, button.gameObject);
                        ctrl.DrawLayer(layer.layers[imageIndex], button.gameObject);
                    }
                }
            }

        }
    }


    [ExecuteInEditMode]
    public class PosLoader : MonoBehaviour
    {
        public Vector2 worldPos;
        void Start()
        {
            transform.position = worldPos;
            DestroyImmediate(this);
        }
    }
}