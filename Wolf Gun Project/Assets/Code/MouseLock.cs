﻿using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour {

	//http://answers.unity3d.com/questions/62440/how-to-stop-mouse-going-out-of-the-screen-.html

//	#isf UNITY_STANDALONE_WIN
//	[DllImport("user32.dll")]
//	static extern bool ClipCursor(ref RECT lpRect);
//	public struct RECT
//	{
//		public int Left;
//		public int Top;
//		public int Right;
//		public int Bottom;
//	}
//	#endif
//	public void Start()
//	{
//		RECT cursorLimits;
//		cursorLimits.Left   = 0;
//		cursorLimits.Top    = 0;
//		cursorLimits.Right  = Screen.width  - 1;
//		cursorLimits.Bottom = Screen.height - 1;
//		ClipCursor(ref cursorLimits);
//	}
}
