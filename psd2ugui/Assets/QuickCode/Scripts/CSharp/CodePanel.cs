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

	#region UI Variable Assignment 
	private void InitUI() 
	{
		image_CodePanel = transform.GetComponent<Image>(); 
		text_Title = transform.Find("Title").GetComponent<Text>(); 
		image_Icon = transform.Find("Icon").GetComponent<Image>(); 
		image_Button = transform.Find("Button").GetComponent<Image>(); 
		button_Button = transform.Find("Button").GetComponent<Button>(); 
		text_Text = transform.Find("Button/Text").GetComponent<Text>(); 
		toggle_Toggle = transform.Find("Toggle").GetComponent<Toggle>(); 
		image_Background = transform.Find("Toggle/Background").GetComponent<Image>(); 
		image_Checkmark = transform.Find("Toggle/Background/Checkmark").GetComponent<Image>(); 
		text_Label = transform.Find("Toggle/Label").GetComponent<Text>(); 
		slider_Slider = transform.Find("Slider").GetComponent<Slider>(); 
		image_Background12 = transform.Find("Slider/Background").GetComponent<Image>(); 
		image_Fill = transform.Find("Slider/Fill Area/Fill").GetComponent<Image>(); 
		image_Handle = transform.Find("Slider/Handle Slide Area/Handle").GetComponent<Image>(); 
		image_Dropdown = transform.Find("Dropdown").GetComponent<Image>(); 
		dropdown_Dropdown = transform.Find("Dropdown").GetComponent<Dropdown>(); 
		text_Label17 = transform.Find("Dropdown/Label").GetComponent<Text>(); 
		image_Arrow = transform.Find("Dropdown/Arrow").GetComponent<Image>(); 
		image_Template = transform.Find("Dropdown/Template").GetComponent<Image>(); 
		scrollrect_Template = transform.Find("Dropdown/Template").GetComponent<ScrollRect>(); 
		mask_Viewport = transform.Find("Dropdown/Template/Viewport").GetComponent<Mask>(); 
		image_Viewport = transform.Find("Dropdown/Template/Viewport").GetComponent<Image>(); 
		toggle_Item = transform.Find("Dropdown/Template/Viewport/Content/Item").GetComponent<Toggle>(); 
		image_Item_Background = transform.Find("Dropdown/Template/Viewport/Content/Item/Item Background").GetComponent<Image>(); 
		image_Item_Checkmark = transform.Find("Dropdown/Template/Viewport/Content/Item/Item Checkmark").GetComponent<Image>(); 
		text_Item_Label = transform.Find("Dropdown/Template/Viewport/Content/Item/Item Label").GetComponent<Text>(); 
		image_Scrollbar = transform.Find("Dropdown/Template/Scrollbar").GetComponent<Image>(); 
		scrollbar_Scrollbar = transform.Find("Dropdown/Template/Scrollbar").GetComponent<Scrollbar>(); 
		image_Handle29 = transform.Find("Dropdown/Template/Scrollbar/Sliding Area/Handle").GetComponent<Image>(); 
		image_InputField = transform.Find("InputField").GetComponent<Image>(); 
		inputfield_InputField = transform.Find("InputField").GetComponent<InputField>(); 
		text_Placeholder = transform.Find("InputField/Placeholder").GetComponent<Text>(); 
		text_Text33 = transform.Find("InputField/Text").GetComponent<Text>(); 

	}
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
