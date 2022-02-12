# Keylogger
Complete monitoring over the local keyboard by integrating low level keyboard hooks using the User32 dll. I copied this code heavily from https://github.com/fabriciorissetto/KeystrokeAPI making my own modifications here and there.

## Code Example 
```c#
class Program
{
    static void Main(string[] args)
    {
        using (var api = new KeystrokeAPI())
        {
            api.CreateKeyboardHook((character) => { Console.Write(character); });
            Application.Run();
        }
    }
}

//note: you will need to reference System.Windows.Forms for Application.Run();
```
