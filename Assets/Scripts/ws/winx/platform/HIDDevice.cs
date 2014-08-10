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
using ws.winx.devices;
namespace ws.winx.platform
{
		public abstract class HIDDevice:IHIDDevice,IDisposable
		{

            public delegate void ReadCallback(object data);
            public delegate void WriteCallback(bool success);

            

				object _Extension;
				
				int _VID;
				int _PID;
				IntPtr _deviceHandle;
				string _devicePath;
				IHIDInterface _hidInterface;
                string _name;
                int _index;
               

               

				public HIDDevice (int index, int VID, int PID, IntPtr deviceHandle, IHIDInterface hidInterface, string devicePath,string name=""
                   )
				{
                    
                        _index = index;
					    _VID = VID;
						_PID = PID;
						_deviceHandle = deviceHandle;
						_hidInterface = hidInterface;
						_devicePath = devicePath;
                        _name = name;
				}



                //public void Read(ReadCa callback)
                //{
                //    throw new Exception("Need to be overrided");
                //}

                //public void Write(Delegate callback)
                //{
                //    throw new Exception("Need to be overrided");
                //}
				


		#region IHIDDeviceInfo implementation




				public object Extension {
						get {
                            return _Extension;
						}
						set {
                            _Extension = value;
						}
				}

                public virtual int InputReportByteLength
                {
                    get;
                    set;
                }


                public virtual int OutputReportByteLength
                {
                    get;
                    set;
                }

			

				public virtual IHIDInterface hidInterface {
						get {
								return _hidInterface;
						}
                    internal set
                    {
                        _hidInterface = value;
                    }

				}

				public int VID {
						get {
								return _VID;
						}
                    internal set
                    {
                        _VID = value;
                    }

				}

				public int PID {
						get {
								return _PID;
						}
                    internal set {
                    _PID=value;
                        }

				}

				public IntPtr deviceHandle {
						get {
								return _deviceHandle;
						}
				}

				public string DevicePath {
						get {
								return _devicePath;
						}

				}


                public string Name
                {
                    get { return _name; }
                    internal set { _name = value; }
                }


                public int index
                {
                    get { return _index; }
                    internal set
                    {
                        _index = value;
                    }
                }





                public virtual void Read(ReadCallback callback)
                {
                    throw new NotImplementedException();
                }

                public virtual void Write(object data,WriteCallback callback)
                {
                    throw new NotImplementedException();
                }

                public virtual void Write(object data)
                {
                    throw new NotImplementedException();
                }

                public virtual void Dispose()
                {
                    throw new NotImplementedException();
                }
        }

		#endregion


               
}

