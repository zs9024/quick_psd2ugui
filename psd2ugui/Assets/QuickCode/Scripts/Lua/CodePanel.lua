--this file is auto created by QuickCode,you can edit it 
--do not need to care initialization of ui wedget any more 
--------------------------------------------------------------------------------
--/**
--* @author :
--* date    :
--* purpose :
--*/
--------------------------------------------------------------------------------
require "class"


local CodePanel = class("CodePanel");

function CodePanel:ctor(...)
	--assign transform by your ui framework
	self.transform = nil;
end

--region UI Variable Assignment 
function CodePanel:InitUI()
	self.image_CodePanel = self.transform:GetComponent("Image"); 
	self.text_Title = self.transform:Find("Title"):GetComponent("Text"); 
	self.image_Icon = self.transform:Find("Icon"):GetComponent("Image"); 
	self.image_Button = self.transform:Find("Button"):GetComponent("Image"); 
	self.button_Button = self.transform:Find("Button"):GetComponent("Button"); 
	self.text_Text = self.transform:Find("Button/Text"):GetComponent("Text"); 
	self.toggle_Toggle = self.transform:Find("Toggle"):GetComponent("Toggle"); 
	self.image_Background = self.transform:Find("Toggle/Background"):GetComponent("Image"); 
	self.image_Checkmark = self.transform:Find("Toggle/Background/Checkmark"):GetComponent("Image"); 
	self.text_Label = self.transform:Find("Toggle/Label"):GetComponent("Text"); 
	self.slider_Slider = self.transform:Find("Slider"):GetComponent("Slider"); 
	self.image_Background12 = self.transform:Find("Slider/Background"):GetComponent("Image"); 
	self.image_Fill = self.transform:Find("Slider/Fill Area/Fill"):GetComponent("Image"); 
	self.image_Handle = self.transform:Find("Slider/Handle Slide Area/Handle"):GetComponent("Image"); 
	self.image_Dropdown = self.transform:Find("Dropdown"):GetComponent("Image"); 
	self.dropdown_Dropdown = self.transform:Find("Dropdown"):GetComponent("Dropdown"); 
	self.text_Label17 = self.transform:Find("Dropdown/Label"):GetComponent("Text"); 
	self.image_Arrow = self.transform:Find("Dropdown/Arrow"):GetComponent("Image"); 
	self.image_Template = self.transform:Find("Dropdown/Template"):GetComponent("Image"); 
	self.scrollrect_Template = self.transform:Find("Dropdown/Template"):GetComponent("ScrollRect"); 
	self.mask_Viewport = self.transform:Find("Dropdown/Template/Viewport"):GetComponent("Mask"); 
	self.image_Viewport = self.transform:Find("Dropdown/Template/Viewport"):GetComponent("Image"); 
	self.toggle_Item = self.transform:Find("Dropdown/Template/Viewport/Content/Item"):GetComponent("Toggle"); 
	self.image_Item_Background = self.transform:Find("Dropdown/Template/Viewport/Content/Item/Item Background"):GetComponent("Image"); 
	self.image_Item_Checkmark = self.transform:Find("Dropdown/Template/Viewport/Content/Item/Item Checkmark"):GetComponent("Image"); 
	self.text_Item_Label = self.transform:Find("Dropdown/Template/Viewport/Content/Item/Item Label"):GetComponent("Text"); 
	self.image_Scrollbar = self.transform:Find("Dropdown/Template/Scrollbar"):GetComponent("Image"); 
	self.scrollbar_Scrollbar = self.transform:Find("Dropdown/Template/Scrollbar"):GetComponent("Scrollbar"); 
	self.image_Handle29 = self.transform:Find("Dropdown/Template/Scrollbar/Sliding Area/Handle"):GetComponent("Image"); 
	self.image_InputField = self.transform:Find("InputField"):GetComponent("Image"); 
	self.inputfield_InputField = self.transform:Find("InputField"):GetComponent("InputField"); 
	self.text_Placeholder = self.transform:Find("InputField/Placeholder"):GetComponent("Text"); 
	self.text_Text33 = self.transform:Find("InputField/Text"):GetComponent("Text"); 

end
--endregion 

--region UI Event Register 
function CodePanel:AddEvent()
	self.button_Button.onClick:AddListener(function () self:OnButtonClicked(); end);
	self.toggle_Toggle.onValueChanged:AddListener(function (args) self:OnToggleValueChanged(args); end);
	self.slider_Slider.onValueChanged:AddListener(function (args) self:OnSliderValueChanged(args); end);
	self.dropdown_Dropdown.onValueChanged:AddListener(function (args) self:OnDropdownValueChanged(args); end);
	self.scrollrect_Template.onValueChanged:AddListener(function (args) self:OnTemplateValueChanged(args); end);
	self.toggle_Item.onValueChanged:AddListener(function (args) self:OnItemValueChanged(args); end);
	self.scrollbar_Scrollbar.onValueChanged:AddListener(function (args) self:OnScrollbarValueChanged(args); end);
	self.inputfield_InputField.onValueChanged:AddListener(function (args) self:OnInputFieldValueChanged(args); end);
end
 

function CodePanel:OnButtonClicked()

end

function CodePanel:OnToggleValueChanged(args)

end

function CodePanel:OnSliderValueChanged(args)

end

function CodePanel:OnDropdownValueChanged(args)

end

function CodePanel:OnTemplateValueChanged(args)

end

function CodePanel:OnItemValueChanged(args)

end

function CodePanel:OnScrollbarValueChanged(args)

end

function CodePanel:OnInputFieldValueChanged(args)

end
--endregion 

return CodePanel;
