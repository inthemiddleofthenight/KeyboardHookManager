# KeyboardHookManager

### Packages

| Source | Link |
| ------ | ------ |
| NuGet |  https://www.nuget.org/packages/KeyboardHookManager |


KeyboardHookManager - dll for global keyboard and mouse event listen.

  - All button press, down and up listen
  - All mouse events
  - Clipboard commands

### Development

Run at once in your desktop app. Also needs select app module for bind event: in
SetWindowsHookEx: set on Init(Module module) or no set and use default: Assembly.GetEntryAssembly().ManifestModule.Assembly.GetModules().FirstOrDefault()

Keyboard Events
```csharp
    HookManager.KeyDown += (s,e) => {};
    HookManager.KeyPress += (s,e) => {};
    HookManager.KeyUp += (s,e) => {};
```

Mouse Events

```csharp
    HookManager.MouseClick  += (s, e) => { };
    HookManager.MouseClickExt += (s, e) => { };
    HookManager.MouseDoubleClick += (s, e) => { };
    HookManager.MouseDown += (s, e) => { };
    HookManager.MouseMove += (s, e) => { };
    HookManager.MouseMoveExt += (s, e) => { };
    HookManager.MouseUp += (s, e) => { };
    HookManager.MouseWheel  += (s, e) => { };
```

License
----

MIT

