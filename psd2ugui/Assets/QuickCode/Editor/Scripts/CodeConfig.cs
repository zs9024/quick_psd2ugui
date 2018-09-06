using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Quick.Code
{
    public class CodeConfig
    {
        /// <summary>
        /// 需要注册事件的UI控件类型
        /// </summary>
        public enum EventWidgetType
        {
            Button,
            Toggle,
            Slider,
            InputField,
            ScrollRect,
            Scrollbar,
            Dropdown,
        }

        public static Dictionary<string, string> eventCBParamDic = new Dictionary<string, string> { { "Toggle", "bool" }, 
            { "Slider", "float" }, { "InputField", "string" }, { "ScrollRect", "Vector2" }, { "Scrollbar", "float" }, { "Dropdown", "int" }, 
        };

        #region cs代码格式
        public const string regionStartFmt = "\n\t#region {0} \n";
        public const string regionEnd = "\t#endregion \n";

        public static string statementRegion = string.Format(regionStartFmt,"UI Variable Statement");
        public static string eventRegion = string.Format(regionStartFmt, "UI Event Register");
        public static string assignRegion = string.Format(regionStartFmt, "UI Variable Assignment");

        public const string methodStartFmt = "\tprivate void {0}() \n\t{{\n";   //'{'要转义
        public const string methodEnd = "\n\t}\n";

        public const string codeAnnotation = @"//this file is auto created by QuickCode,you can edit it 
//do not need to care initialization of ui widget any more 
//------------------------------------------------------------------------------
/**
* @author :
* date    :
* purpose :
*/
//------------------------------------------------------------------------------";
        public const string usingNamespace = "\nusing UnityEngine;\nusing System.Collections;\nusing UnityEngine.UI;\n";
        public const string classMonoStart = "\npublic class {0} : MonoBehaviour\n{{\n";
        public const string classStart = "\npublic class {0}\n{{\n";
        public const string classEnd = "\n}\n";
        public const string methodAnnotation = "\n\t/// <summary>\n\t/// {0}\n\t/// </summary>\n";
             

        #region 序列化初始化代码格式
        //控件遍历声明,0:类型 1:名称
        public const string serilStateCodeFmt = "\t[SerializeField] private {0} {1}; \n";

        public const string onClickSerilCode        = "\t\t{0}.onClick.AddListener(On{1}Clicked); \n";
        public const string onValueChangeSerilCode  = "\n\t\t{0}.onValueChanged.AddListener(On{1}ValueChanged);";

        public const string btnCallbackSerilCode        = "\n\tprivate void On{0}Clicked()\n\t{{\n\n\t}}\n";
        public const string eventCallbackSerilCode = "\n\tprivate void On{0}ValueChanged({1} arg)\n\t{{\n\n\t}}\n";
        #endregion

        #region 控件查找赋值格式
        public const string assignCodeFmt = "\t\t{0} = transform.Find(\"{1}\").GetComponent<{2}>(); \n";
        public const string assignGameObjectCodeFmt = "\t\t{0} = transform.Find(\"{1}\").gameObject; \n";
        //根物体上挂载的控件
        public const string assignRootCodeFmt = "\t\t{0} = transform.GetComponent<{1}>(); \n";
        #endregion

        #region 查找初始化代码格式
        public const string stateTransform = "\tprivate Transform transform; \n";
        public const string stateCodeFmt = "\tprivate {0} {1}; \n";
        public const string assignTransform = "\t\t//assign transform by your ui framework\n\t\t//transform = ; \n";
        #endregion

        #endregion

        #region lua代码格式
        public const string regionStartFmtLua = "\n--region {0} \n";
        public const string regionEndLua = "--endregion \n";

        public static string eventRegionLua = string.Format(regionStartFmtLua, "UI Event Register");
        public static string assignRegionLua = string.Format(regionStartFmtLua, "UI Variable Assignment");

        public const string methodStartFmtLua = "function Class:{0}()\n";
        public const string methodEndLua = "\nend\n";

        public const string codeAnnotationLua = @"--this file is auto created by QuickCode,you can edit it 
--do not need to care initialization of ui widget any more 
--------------------------------------------------------------------------------
--/**
--* @author :
--* date    :
--* purpose :
--*/
--------------------------------------------------------------------------------";

        public const string assignCodeFmtLua = "\tself.{0} = self.transform:Find(\"{1}\"):GetComponent(\"{2}\"); \n";
        public const string assignGameObjectCodeFmtLua = "\t\tself.{0} = self.transform.Find(\"{1}\").gameObject; \n";
        //根物体上挂载的控件
        public const string assignRootCodeFmtLua = "\tself.{0} = self.transform:GetComponent(\"{1}\"); \n";

        public const string onClickSerilCodeLua = "\tself.{0}.onClick:AddListener(function () self:On{1}Clicked(); end); \n";
        public const string onValueChangeSerilCodeLua = "\n\tself.{0}.onValueChanged:AddListener(function (args) self:On{1}ValueChanged(args); end);";
        public const string btnCallbackSerilCodeLua = "\nfunction Class:On{0}Clicked()\n\nend\n";
        public const string eventCallbackSerilCodeLua = "\nfunction Class:On{0}ValueChanged(args)\n\nend\n";

        //文件和类
        public const string requireCode = "\nrequire \"class\"\n\n";
        public const string classStartLua = "\nlocal {0} = class(\"{1}\");\n";
        public const string classEndLua = "\nreturn {0};\n";
        public const string classCtorLua = "\nfunction {0}:ctor(...)\n\t--assign transform by your ui framework\n\tself.transform = nil;\nend\n";
        #endregion
    }
}
