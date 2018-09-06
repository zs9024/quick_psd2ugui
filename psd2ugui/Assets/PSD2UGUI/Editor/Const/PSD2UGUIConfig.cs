using PSDUIImporter;
using UnityEngine;

[CreateAssetMenu(fileName = "PSD2UGUIConfig", menuName = "Creat PSD2UGUIConfig Asset")]
public class PSD2UGUIConfig : ScriptableObject
{
    [Header("通用图集路径")]
    public string m_commonAtlasPath = PSDImporterConst.Globle_BASE_FOLDER;

    [Space(10)]
    [Header("图集名")]
    public string m_commonAtlasName = PSDImporterConst.Globle_FOLDER_NAME;

    [Header("字体资源路径")]
    public string m_fontPath = PSDImporterConst.FONT_FOLDER;

    [Header("静态字体资源路径")]
    public string m_staticFontPath = PSDImporterConst.FONT_STATIC_FOLDER;

    [Header("资源模板加载路径")]
    public string m_psduiTemplatePath = PSDImporterConst.PSDUI_PATH;
}