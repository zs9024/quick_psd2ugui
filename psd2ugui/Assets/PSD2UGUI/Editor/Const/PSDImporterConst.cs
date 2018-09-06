using UnityEditor;
using UnityEngine;

namespace PSDUIImporter
{
    public class PSDImporterConst
    {
        public const string __CONFIG_PATH = "Assets/PSD2UGUI/PSD2UGUIConfig.asset";

        public const string BASE_FOLDER = "UI/";
        public const string PNG_SUFFIX = ".png";

        /// <summary>
        /// 公用图片路径，按需修改
        /// </summary>
        public static string Globle_BASE_FOLDER = "Assets/Textures/HomeCommon/";

        /// <summary>
        /// 图集文件名
        /// </summary>
        public static string Globle_FOLDER_NAME = "HomeCommon";

        /// <summary>
        ///
        /// </summary>
        public const string RENDER = "Render";

        public const string NINE_SLICE = "9Slice";

        public const string IMAGE = "Image";

        /// <summary>
        /// 字体路径，按需修改
        /// </summary>
        public static string FONT_FOLDER = "Assets/PSD2UGUI/Font/";

        public static string FONT_STATIC_FOLDER = "Assets/PSD2UGUI/Font/StaticFont/";

        public const string FONT_SUFIX = ".ttf";

        /// <summary>
        /// 修改资源模板加载路径,不能放在resources目录
        /// </summary>
        public static string PSDUI_PATH = "Assets/PSD2UGUI/Template/UI/";

        public const string PSDUI_SUFFIX = ".prefab";

        public static string ASSET_PATH_EMPTY = PSDUI_PATH + "Empty" + PSDUI_SUFFIX;
        public static string ASSET_PATH_BUTTON = PSDUI_PATH + "Button" + PSDUI_SUFFIX;
        public static string ASSET_PATH_TOGGLE = PSDUI_PATH + "Toggle" + PSDUI_SUFFIX;
        public static string ASSET_PATH_CANVAS = PSDUI_PATH + "Canvas" + PSDUI_SUFFIX;
        public static string ASSET_PATH_EVENTSYSTEM = PSDUI_PATH + "EventSystem" + PSDUI_SUFFIX;
        public static string ASSET_PATH_GRID = PSDUI_PATH + "Grid" + PSDUI_SUFFIX;
        public static string ASSET_PATH_IMAGE = PSDUI_PATH + "Image" + PSDUI_SUFFIX;
        public static string ASSET_PATH_RAWIMAGE = PSDUI_PATH + "RawImage" + PSDUI_SUFFIX;
        public static string ASSET_PATH_HALFIMAGE = PSDUI_PATH + "HalfImage" + PSDUI_SUFFIX;
        public static string ASSET_PATH_SCROLLVIEW = PSDUI_PATH + "ScrollView" + PSDUI_SUFFIX;
        public static string ASSET_PATH_SLIDER = PSDUI_PATH + "Slider" + PSDUI_SUFFIX;
        public static string ASSET_PATH_TEXT = PSDUI_PATH + "Text" + PSDUI_SUFFIX;
        public static string ASSET_PATH_SCROLLBAR = PSDUI_PATH + "Scrollbar" + PSDUI_SUFFIX;
        public static string ASSET_PATH_GROUP_V = PSDUI_PATH + "VerticalGroup" + PSDUI_SUFFIX;
        public static string ASSET_PATH_GROUP_H = PSDUI_PATH + "HorizontalGroup" + PSDUI_SUFFIX;
        public static string ASSET_PATH_INPUTFIELD = PSDUI_PATH + "InputField" + PSDUI_SUFFIX;
        public static string ASSET_PATH_LAYOUTELEMENT = PSDUI_PATH + "LayoutElement" + PSDUI_SUFFIX;
        public static string ASSET_PATH_TAB = PSDUI_PATH + "Tab" + PSDUI_SUFFIX;
        public static string ASSET_PATH_TABGROUP = PSDUI_PATH + "TabGroup" + PSDUI_SUFFIX;

        public PSDImporterConst()
        {
            LoadConfig();
        }

        /// <summary>
        /// 读取工具
        /// </summary>
        public static void LoadConfig()
        {
            // 重读资源路径
            PSD2UGUIConfig _config = AssetDatabase.LoadAssetAtPath<PSD2UGUIConfig>(__CONFIG_PATH);

            if (_config != null)
            {
                Globle_BASE_FOLDER = _config.m_commonAtlasPath;
                Globle_FOLDER_NAME = _config.m_commonAtlasName;
                FONT_FOLDER = _config.m_fontPath;
                FONT_STATIC_FOLDER = _config.m_staticFontPath;
                PSDUI_PATH = _config.m_psduiTemplatePath;

				// 重生成路径
                ASSET_PATH_EMPTY = PSDUI_PATH + "Empty" + PSDUI_SUFFIX;
                ASSET_PATH_BUTTON = PSDUI_PATH + "Button" + PSDUI_SUFFIX;
                ASSET_PATH_TOGGLE = PSDUI_PATH + "Toggle" + PSDUI_SUFFIX;
                ASSET_PATH_CANVAS = PSDUI_PATH + "Canvas" + PSDUI_SUFFIX;
                ASSET_PATH_EVENTSYSTEM = PSDUI_PATH + "EventSystem" + PSDUI_SUFFIX;
                ASSET_PATH_GRID = PSDUI_PATH + "Grid" + PSDUI_SUFFIX;
                ASSET_PATH_IMAGE = PSDUI_PATH + "Image" + PSDUI_SUFFIX;
                ASSET_PATH_RAWIMAGE = PSDUI_PATH + "RawImage" + PSDUI_SUFFIX;
                ASSET_PATH_HALFIMAGE = PSDUI_PATH + "HalfImage" + PSDUI_SUFFIX;
                ASSET_PATH_SCROLLVIEW = PSDUI_PATH + "ScrollView" + PSDUI_SUFFIX;
                ASSET_PATH_SLIDER = PSDUI_PATH + "Slider" + PSDUI_SUFFIX;
                ASSET_PATH_TEXT = PSDUI_PATH + "Text" + PSDUI_SUFFIX;
                ASSET_PATH_SCROLLBAR = PSDUI_PATH + "Scrollbar" + PSDUI_SUFFIX;
                ASSET_PATH_GROUP_V = PSDUI_PATH + "VerticalGroup" + PSDUI_SUFFIX;
                ASSET_PATH_GROUP_H = PSDUI_PATH + "HorizontalGroup" + PSDUI_SUFFIX;
                ASSET_PATH_INPUTFIELD = PSDUI_PATH + "InputField" + PSDUI_SUFFIX;
                ASSET_PATH_LAYOUTELEMENT = PSDUI_PATH + "LayoutElement" + PSDUI_SUFFIX;
                ASSET_PATH_TAB = PSDUI_PATH + "Tab" + PSDUI_SUFFIX;
                ASSET_PATH_TABGROUP = PSDUI_PATH + "TabGroup" + PSDUI_SUFFIX;
				
                Debug.Log("Load config.");
            }

            // Debug.LogError(_config.m_staticFontPath);
        }
    }
}