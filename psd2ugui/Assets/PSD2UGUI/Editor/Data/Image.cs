using System;
using UnityEngine;
namespace PSDUIImporter
{
    public class PSImage
    {
        public ImageType imageType;
        public ImageSource imageSource;
        public string name;
        public Position position;
        public Size size;

        public string[] arguments;

        /// <summary>
        /// 图层透明度
        /// </summary>
        public float opacity = -1;

        /// <summary>
        /// 渐变,这个需要自己写脚本支持,这里只是提供接口
        /// </summary>
        public string gradient = "";

        /// <summary>
        /// 描边
        /// </summary>
        public string outline = "";
    }
}