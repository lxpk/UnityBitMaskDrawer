# UnityBitMaskDrawer
Unity BitMaskDrawer implements a default inspector for bitmask flag enums allowing multiple enums without a custom inspector, originally by Bunny83

## SOURCE
* Code by Bunny83 http://answers.unity3d.com/questions/393992/custom-inspector-multi-select-enum-dropdown.html

## What is a Bitmask and how do you programmers use them?
* Bit masks are a way to flag multiple values on and off within a single integer number.
* http://stu.mp/2004/06/a-quick-bitmask-howto-for-programmers.html

## INSTRUCTIONS
* To enable inspecting of your enums with multiple bitmask flags, add a decorator above your enum declarations like this:

```cs
public enum EMyEnum
{

	None         = 0x00,

	Cow          = 0x01,
		
	Chicken      = 0x02,
		
	Cat          = 0x04,
		
	Dog          = 0x08,
		
	CowChicken   = 0x03,
		
	CatDog       = 0x0C,
		
	All          = 0x0F,
	
}
	
	
[BitMask(typeof(EMyEnum))]
	
public EMyEnum someMask;
```

* Be sure to include a None = 0x00 and All = 0x0F value in the enum.
* Make each enum value equal to a hex power of 2 value.
* If you want to make a custom inspector, you can do it the built-in way: http://docs.unity3d.com/ScriptReference/EditorGUILayout.EnumMaskField.html

## SEE ALSO
There are other examples that implement this concept available:
* Wiki version has custom names: http://wiki.unity3d.com/index.php/EnumFlagPropertyDrawer
	* ChemiKhazi has a Gist: https://gist.github.com/ChemiKhazi/11395776
	* iKriz fixed a bug with arrays in this fork: https://gist.github.com/ikriz/b0f9d96205629e19859e
* Probably similar to https://www.assetstore.unity3d.com/en/?#!/content/12206 which is just $5 if you want to support a paid version