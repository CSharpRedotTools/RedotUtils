using Godot;

namespace RedotUtils;

public static class RWindow
{
    public static void SetTitle(string title)
    {
        DisplayServer.WindowSetTitle(title);
    }

    public static Vector2 GetCenter()
    {
        return new(GetWidth() / 2, GetHeight() / 2);
    }

    public static int GetWidth()
    {
        return DisplayServer.WindowGetSize().X;
    }

    public static int GetHeight()
    {
        return DisplayServer.WindowGetSize().Y;
    }
}

