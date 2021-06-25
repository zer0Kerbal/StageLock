using System;
using UnityEngine;
using KSP.UI.Screens;
using System.Numerics;

namespace StageLock
{
	[KSPAddon(KSPAddon.Startup.Flight, false)]
	public class StageLock : MonoBehaviour
	{
		static bool? STAGE_LOCK;

		// const string KEYBINDCFG = "GameData/ToggleLadderExit/PluginData/keybind.cfg";
		const KeyCode DefaultKeyBindA = KeyCode.LeftAlt;//+ KeyCode.L;
		const KeyCode DefaultKeyBindB = KeyCode.RightAlt;//+ KeyCode.L;

		KeyCode keyBind = DefaultKeyBindA;

		//static ToolbarControl toolbarControl;
		internal const string MODID = "StageLock";
		internal const string MODNAME = "StageLock";

		const string NODENAME = "STAGELOCK";
		//		const string VALUENAME = "keycode";
		bool toggled = false;


		private void stageLockToggle()
		{
			GameSettings.STAGE_LOCK = !GameSettings.STAGE_LOCK;
			switch (GameSettings.STAGE_LOCK)
			{
				case true:
					ScreenMessages.PostScreenMessage("Stage Lock Enabled");
					break;
				case false:
					ScreenMessages.PostScreenMessage("Stage Lock Disabled");
					break;
			}
			//         SetToolbarIcon();
		}

		public void Start()
		{

		}

		public void Update()
		{
			if false //ApplicationLauncher.AppScenes.FLIGHT. | ApplicationLauncher.AppScenes.MAPVIEW
			{
				bool b = Input.GetKey(keyBind);
				if (!toggled && b)
				{
					toggled = true;
					//	stageLockToggle();
				}
				else
				{
					if (toggled && !b)
					{
						//	stageLockToggle();
						toggled = false;
					}
				}
			}
		}
	}
}
