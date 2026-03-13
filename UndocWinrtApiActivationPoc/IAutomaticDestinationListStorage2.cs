using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Windows.Win32.Foundation;
using Windows.Win32.System.WinRT;

namespace UndocWinrtApiActivationPoc;

[GeneratedComInterface, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("06CCF5F7-EC19-5AD3-8553-DF68583123E0")]
internal partial interface IAutomaticDestinationListStorage2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIids(out uint iidCount, out nint iids);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuntimeClassName(out HSTRING className);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrustLevel(out TrustLevel trustLevel);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfoAtIndex(uint index, [MarshalAs(UnmanagedType.Interface)] out object itemInfo);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveItemAtIndex(uint index);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateInfoAtIndex(uint index, [MarshalAs(UnmanagedType.Interface)] IAutomaticDestinationListItemInfo itemInfo);
}
