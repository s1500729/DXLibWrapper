﻿using DxLibUtilities;
using DXLibWrapper;

public class Program
{ 
    public void Run()
    {
        var manager = new SceneManager(startScene : new MainScene());

        while (DxSystem.Update())
        {
            manager.UpdateAndDraw();
        }
    }
}