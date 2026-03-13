using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.WinRT;
using Windows.Win32.System.WinRT.InteropServices;

namespace UndocWinrtApiActivationPoc;

[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(HStringStringMarshaller.ManagedToUnmanagedIn))]
[CustomMarshaller(typeof(string), MarshalMode.UnmanagedToManagedIn, typeof(HStringStringMarshaller.UnmanagedToManagedIn))]
internal static unsafe class HStringStringMarshaller
{
    public ref struct ManagedToUnmanagedIn
    {
        private WindowsDeleteStringSafeHandle _hstring;

        public void FromManaged(string? managed)
        {
            if (managed is null)
            {
                _hstring = new WindowsDeleteStringSafeHandle(nint.Zero);
                return;
            }

            int hr = PInvoke.WindowsCreateString(
                managed,
                checked((uint)managed.Length),
                out _hstring);

            if (hr < 0)
            {
                Marshal.ThrowExceptionForHR(hr);
            }
        }

        public nint ToUnmanaged()
            => _hstring.IsInvalid ? nint.Zero : _hstring.DangerousGetHandle();

        public void Free()
        {
            if (_hstring is not null && !_hstring.IsInvalid)
            {
                _hstring.Close();
            }
        }
    }

    public ref struct UnmanagedToManagedIn
    {
        private nint _hstring;

        public void FromUnmanaged(nint unmanaged)
        {
            _hstring = unmanaged;
        }

        public string? ToManaged()
        {
            if (_hstring == 0)
                return null;

            PCWSTR buffer = PInvoke.WindowsGetStringRawBuffer(new WindowsDeleteStringSafeHandle(_hstring), out uint length);
            return new string((char*)buffer.Value, 0, checked((int)length));
        }

        public void Free()
        {
        }
    }
}
