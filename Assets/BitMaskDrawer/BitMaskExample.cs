using UnityEngine;
using System.Collections;

public class BitMaskExample : MonoBehaviour {

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
}
