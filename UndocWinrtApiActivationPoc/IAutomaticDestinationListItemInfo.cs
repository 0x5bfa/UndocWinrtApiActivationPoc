using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Windows.Win32.Foundation;

namespace UndocWinrtApiActivationPoc;

[GeneratedComInterface, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("96AD31E7-192B-5D9E-B84F-DCC1553BC5D9")]
internal partial interface IAutomaticDestinationListItemInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIids(out uint iidCount, out uint iids);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuntimeClassName(out uint className);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrustLevel(out int trustLevel);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UsagePoints(out double value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UsagePoints(double value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastUsed(out long value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LastUsed(long value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActionCount(out uint value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ActionCount(uint value);
}
