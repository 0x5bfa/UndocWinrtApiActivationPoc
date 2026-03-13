using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Windows.Win32.Foundation;
using Windows.Win32.System.WinRT;

namespace UndocWinrtApiActivationPoc;

[GeneratedComInterface, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("4DBD7969-19C5-5F8D-BAA0-0489BD97DE0E")]
internal partial interface IAutomaticDestinationListStorage
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
    HRESULT ItemCount(out uint value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PinnedItemCount(out uint value);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddItem(IntPtr storageItem, [MarshalAs(UnmanagedType.U1)] bool flag, out int index);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveItem(IntPtr storageItem);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PinItem(IntPtr storageItem, int pinPosition);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnpinItem(IntPtr storageItem);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearList();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemAtIndex(uint index, out IntPtr storageItem);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddUsagePointsForItem(IntPtr storageItem, double usagePoints, [MarshalAs(UnmanagedType.U1)] bool flag);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfoForItem(IntPtr storageItem, out IntPtr itemInfo);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateInfoForItem(IntPtr storageItem, IntPtr itemInfo);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(int access, [MarshalUsing(typeof(HStringStringMarshaller))] string appFullPath, [MarshalUsing(typeof(HStringStringMarshaller))] string appId, [MarshalUsing(typeof(HStringStringMarshaller))] string customAutoDestFullFilePath);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExtendedProperties(out IntPtr valueSet);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ExtendedProperties(IntPtr valueSet);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
