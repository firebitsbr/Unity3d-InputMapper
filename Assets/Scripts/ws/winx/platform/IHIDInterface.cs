//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using ws.winx.devices;
namespace ws.winx.platform
{
		public interface IHIDInterface
		{
            
			IJoystickDriver defaultDriver{get;set;}
			IDeviceCollection Devices{get;}
			void Update();
		    

		}
}

