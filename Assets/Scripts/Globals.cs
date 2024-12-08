using UI;
using UnityEngine.Rendering;

public static class Globals
{
    public static Settings Settings;

    public static string RootFolder
    {
        get { return FileSystemHelpers.RootFolder; }
    }

    public static Loader Loader;

    public static MenuController StartMenu;
    public static OptionsMenu OptionsMenu;
    public static MicroMenu MicroMenu;
    public static Volume volume;
}
