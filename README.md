# 解析psd文件，一键生成ugui面板工具
支持文本，图片，按钮，滑动条，网格布局等组件的导出和生成<br> 
支持九宫格图片的自动剪切和生成<br> 
支持对称图片切半版的导出和生成<br> 
支持滑动列表和列表元素自动布局<br> 
使用规则详见文档：Assets/PSD2UGUI/Doc/“使用说明”<br> 
----------------------------------------------------------------------
  测试所用版本，unity 版本：5.3.3f1，ps版本：cs6 64位<br> 
## 使用
* 将脚本文件 Export PSDUI.jsx拷贝至“ps安装目录\Presets\Scripts”目录下，如：“E:\Program Files\PS\Adobe Photoshop CS6 (64 Bit)\Presets\Scripts”。
* 打开一个psd文件，在cs6中选择“文件->脚本->Export PSDUI”，会弹框选择一个目录，存放脚本运行时的切图和配置文件(xml)。
* 将上一步生成的切图和配置拷贝到unity中，在菜单栏选择quicktool/psdimport执行，弹框选择上一步导出的xml文件，将在hierarchy中生成ugui面板
* ui生成以后可使用quicktool/QuickGenCode 快速生成ui脚本，具体使用参见 https://github.com/zs9024/quick_uicode
## 提示
* 使用编辑器修改或调试ps脚本：找到或下载编辑器adobe extendscript toolkit，一般都在C盘，如C:\Program Files (x86)\Adobe\Adobe Utilities - CS6\ExtendScript Toolkit CS6，
file/open打开文件“ps安装目录\Presets\Scripts\Export PSDUI.jsx”，目标应用选择“Adobe Photoshop CS6”，就可以断点调试运行了
* 如果运行ps脚本时出现错误“合并可见图层当前不可用”，可以检查是否有单个图片(比如背景图)位于根节点的最后，并将其移到某个图层组下面，具体见文档
* ps cc版本报错“错误8800...sceneData += "<string>" + obj.textItem.color.rgb.hexValue + "</string>";”时，可检查text是不是包含了多个色值，要用单色，多色在unity里自己用richtext的color实现
* 有问题或者建议、想法可以加QQ群654564220讨论
## 版本
  v1.0.5<br>
  2018.08.20<br>
  1.添加输入框导入<br>
  2.支持文本在PS中设置透明度,导出以后在Unity中生效<br>
  3.添加OutLine支持<br>

  v1.0.5<br>
  2018.03.06<br>
  1.整合快速ui代码生成（QuickCode）模块<br>
  2.ps cc text报错说明<br>
  3.bug修复<br>

  v1.0.4<br> 
  2017.10.10<br> 
  1.增加toggle组件的导出和生成<br>
  2.增加自定义页签组件的导出和生成<br> 
  3.layer的绘制优化<br> 
  4.代码复用和优化<br> 
  
  v1.0.3<br> 
  2017.6.20<br> 
  1.增加mirror效果，修改对称图片的生成方式为镜像<br> 
  2.增加上下左右均对称图片的导出和生成<br> 
  3.按钮的背景增加九宫和半图样式<br> 
  
  v1.0.2<br> 
  2017.02.06<br> 
  1.增加网格布局(GridLayoutGroup)组件的导出和生成<br> 
  2.增加滑动条(Slider)组件的导出和生成<br> 

  v1.0.1<br> 
  2017.01.22<br> 
  1.修改导出psd时的xml配置结构，改images层级为layer，ugui生成代码对应修改<br> 
  2.增加九宫格的导出，根据命名时的border值自动切九宫格图<br> 
  3.滑动列表（ScrollRect）的导出和生成，可动态布局滑动项,支持单行和单列，暂不支持grid<br> 

  v1.0.0<br> 
  2017.01.12<br> 
  1.正常文本的导出和生成<br> 
  2.静态文本和图片文本的导出和生成<br> 
  3.正常图片的导出和生成<br> 
  4.九宫格的生成，暂时无法从ps导出，还需手动切图<br> 
  5.RawImage的导出和生成<br> 
  6.对称图片切半的导出和生成<br> 
  7.公用图片的导出和生成<br> 
  8.按钮控件的导出和生成<br> 
