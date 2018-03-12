//this file is auto created by QuickCode,you can edit it 
//do not need to care initialization of ui widget any more 
//------------------------------------------------------------------------------
/**
* @author :
* date    :
* purpose :
*/
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{

	#region UI Variable Statement 
	[SerializeField] private Image image_CodePanel; 
	[SerializeField] private Text text_Title; 
	[SerializeField] private Image image_Icon; 
	[SerializeField] private Image image_Button; 
	[SerializeField] private Button button_Button; 
	[SerializeField] private Text text_Text; 
	[SerializeField] private Toggle toggle_Toggle; 
	[SerializeField] private Image image_Background; 
	[SerializeField] private Image image_Checkmark; 
	[SerializeField] private Text text_Label; 
	[SerializeField] private Slider slider_Slider; 
	[SerializeField] private Image image_Background12; 
	[SerializeField] private Image image_Fill; 
	[SerializeField] private Image image_Handle; 
	[SerializeField] private Image image_Dropdown; 
	[SerializeField] private Dropdown dropdown_Dropdown; 
	[SerializeField] private Text text_Label17; 
	[SerializeField] private Image image_Arrow; 
	[SerializeField] private Image image_Template; 
	[SerializeField] private ScrollRect scrollrect_Template; 
	[SerializeField] private Mask mask_Viewport; 
	[SerializeField] private Image image_Viewport; 
	[SerializeField] private Toggle toggle_Item; 
	[SerializeField] private Image image_Item_Background; 
	[SerializeField] private Image image_Item_Checkmark; 
	[SerializeField] private Text text_Item_Label; 
	[SerializeField] private Image image_Scrollbar; 
	[SerializeField] private Scrollbar scrollbar_Scrollbar; 
	[SerializeField] private Image image_Handle29; 
	[SerializeField] private Image image_InputField; 
	[SerializeField] private InputField inputfield_InputField; 
	[SerializeField] private Text text_Placeholder; 
	[SerializeField] private Text text_Text33; 
	#endregion 

	#region UI Event Register 
	private void AddEvent() 
	{
		button_Button.onClick.AddListener(OnButtonClicked);
		toggle_Toggle.onValueChanged.AddListener(OnToggleValueChanged);
		slider_Slider.onValueChanged.AddListener(OnSliderValueChanged);
		dropdown_Dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
		scrollrect_Template.onValueChanged.AddListener(OnTemplateValueChanged);
		toggle_Item.onValueChanged.AddListener(OnItemValueChanged);
		scrollbar_Scrollbar.onValueChanged.AddListener(OnScrollbarValueChanged);
		inputfield_InputField.onValueChanged.AddListener(OnInputFieldValueChanged);
	}
 
	private void OnButtonClicked()
	{

	}

	private void OnToggleValueChanged(bool arg)
	{

	}

	private void OnSliderValueChanged(float arg)
	{

	}

	private void OnDropdownValueChanged(int arg)
	{

	}

	private void OnTemplateValueChanged(Vector2 arg)
	{

	}

	private void OnItemValueChanged(bool arg)
	{

	}

	private void OnScrollbarValueChanged(float arg)
	{

	}

	private void OnInputFieldValueChanged(string arg)
	{

	}
	#endregion 

}
