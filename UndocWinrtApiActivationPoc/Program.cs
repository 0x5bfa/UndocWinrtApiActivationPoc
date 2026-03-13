using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.WinRT;

namespace UndocWinrtApiActivationPoc;

class Program
{
    static void Main()
    {
        const string activationId = "Windows.Internal.AutomaticDestinationListStorage";

        HRESULT hr;

        hr = PInvoke.RoInitialize(RO_INIT_TYPE.RO_INIT_MULTITHREADED);

        hr = PInvoke.WindowsCreateString(activationId, (uint)activationId.Length, out var activationIdAsHSTRING);

        hr = PInvoke.RoActivateInstance(activationIdAsHSTRING, out var obj);
        if (hr.Failed || obj is not IAutomaticDestinationListStorage storage)
            return;

        //hr = storage.Load(1, "C:\\Windows\\explorer.exe", "Microsoft.Windows.Explorer", null!);

        //if (obj is not IAutomaticDestinationListStorage2 storage2)
        //    return;

        //hr = storage2.GetInfoAtIndex(1, out var itemInfoObj);
        //if (hr.Failed || itemInfoObj is not IAutomaticDestinationListItemInfo itemInfo)
        //    return;

        //hr = itemInfo.get_ActionCount(out uint actionCount);
        //hr = itemInfo.put_ActionCount(7);

        //hr = storage2.UpdateInfoAtIndex(1, itemInfo);
        //hr = storage.Save();

        // Clean up
        activationIdAsHSTRING.Close();
        PInvoke.RoUninitialize();
    }
}
