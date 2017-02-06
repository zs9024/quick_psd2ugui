using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

namespace PSDUIImporter
{
    //只有一半的图片的生成类，需要组合拼接
    public class HalfSpriteImport : IImageImport
    {
        public void DrawImage(PSImage image, GameObject parent, GameObject ownObj = null)
        {
            RectTransform halfRectTrans = parent.GetComponent<RectTransform>();

            //2017.1.20注：因为已经修改为layer会创建gameobject，所以不再需要加载预设,直接在parent下组装即可
            //创建一个节点存放两张半图  
            //var halfRectTrans = PSDImportUtility.LoadAndInstant<RectTransform>(PSDImporterConst.ASSET_PATH_HALFIMAGE, image.name, parent);
            PSDImportUtility.SetAnchorMiddleCenter(halfRectTrans);
            halfRectTrans.sizeDelta = new Vector2(image.size.width, image.size.height);
            halfRectTrans.anchoredPosition = new Vector2(image.position.x, image.position.y);

            UnityEngine.UI.Image leftOrUpSprite = PSDImportUtility.LoadAndInstant<UnityEngine.UI.Image>(PSDImporterConst.ASSET_PATH_IMAGE, image.name, halfRectTrans.gameObject);
            UnityEngine.UI.Image rightOrLowSprite = PSDImportUtility.LoadAndInstant<UnityEngine.UI.Image>(PSDImporterConst.ASSET_PATH_IMAGE, image.name, halfRectTrans.gameObject);

            string assetPath = "";
            if (image.imageSource == ImageSource.Common || image.imageSource == ImageSource.Custom)
            {
                assetPath = PSDImportUtility.baseDirectory + image.name + PSDImporterConst.PNG_SUFFIX;
            }
            else
            {
                assetPath = PSDImporterConst.Globle_BASE_FOLDER + image.name.Replace(".", "/") + PSDImporterConst.PNG_SUFFIX;
            }

            Sprite sprite = AssetDatabase.LoadAssetAtPath(assetPath, typeof(Sprite)) as Sprite;
            if (sprite == null)
            {
                Debug.Log("loading asset at path: " + assetPath);
            }

            leftOrUpSprite.sprite = sprite;
            rightOrLowSprite.sprite = sprite;
            RectTransform lOrURectTrans = leftOrUpSprite.GetComponent<RectTransform>();
            RectTransform rOrLRectTrans = rightOrLowSprite.GetComponent<RectTransform>();

            Vector2 size;
            if (image.imageType == ImageType.UpHalfImage)
            {
                size = new Vector2(image.size.width, image.size.height / 2f);
                lOrURectTrans.sizeDelta = size;
                lOrURectTrans.anchoredPosition = new Vector2(image.position.x, image.position.y + image.size.height / 4f);//还未设置父节点，要用绝对坐标

                rOrLRectTrans.sizeDelta = size;
                rOrLRectTrans.anchoredPosition = new Vector2(image.position.x, image.position.y - image.size.height / 4f);
                rOrLRectTrans.localEulerAngles = new Vector3(180, 0, 0);
            }
            else
            {
                size = new Vector2(image.size.width / 2f, image.size.height);
                lOrURectTrans.sizeDelta = size;
                lOrURectTrans.anchoredPosition = new Vector2(image.position.x - image.size.width / 4f, image.position.y);
                rOrLRectTrans.sizeDelta = size;
                rOrLRectTrans.anchoredPosition = new Vector2(image.position.x + image.size.width / 4f, image.position.y);
                rOrLRectTrans.localEulerAngles = new Vector3(0, 180, 0);
            }

            
        }
    }
}
