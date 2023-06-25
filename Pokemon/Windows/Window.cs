using System;
using System.Runtime.InteropServices;

public class Window {

    private const int SW_MAXIMIZE = 3;
    [DllImport( "user32.dll" )]
    private static extern bool ShowWindow( nint hWnd, int nCmdShow );
    [DllImport( "kernel32.dll", ExactSpelling = true )]
    private static extern nint GetConsoleWindow();

    private int _height;
    private int _width;
    public int Height {
        get { return _height; }
        set { _height = value; }
    }
    public int Width {
        get { return _width; }
        set { _width = value; }
    }
    public Window() {
        nint consoleWindow = GetConsoleWindow();
        if( consoleWindow != nint.Zero ) {
            ShowWindow( consoleWindow, SW_MAXIMIZE );
        }
        Console.SetWindowSize( Console.LargestWindowWidth, Console.LargestWindowHeight );
        Console.SetBufferSize( Console.LargestWindowWidth, Console.LargestWindowHeight );
        Console.CursorVisible = false;

        Height = Console.WindowHeight - 2;
        Width = Console.WindowWidth - 2;
    }
}