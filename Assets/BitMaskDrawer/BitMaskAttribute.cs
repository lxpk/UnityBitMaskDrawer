using UnityEngine;
using System.Collections;

//C#
 
 // Have to be defined somewhere in a runtime script file
 public class BitMaskAttribute : PropertyAttribute
 {
	 public System.Type propType;
	 public BitMaskAttribute(System.Type aType)
	 {
		 propType = aType;
	 }
 }