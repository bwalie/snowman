using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace Lumiukko;

/// @author rachel.htike
/// @version 19.03.2024
/// <summary>
/// 
/// </summary>
public class Lumiukko : PhysicsGame
{
    public override void Begin()
    {
        // Kirjoita ohjelmakoodisi tähän
            Camera.ZoomToLevel();
            Level.Background.Color = Color.Black;

            PhysicsObject p1 = new PhysicsObject(200.0, 200.0, Shape.Circle);
            p1.Y = Level.Bottom + 200.0;
            Add(p1);

            PhysicsObject p2 = new PhysicsObject(100.0, 100.0, Shape.Circle);
            p2.Y = p1.Y + 100 + 50;
            p2.Color = Color.HotPink;
            Add(p2);

            PhysicsObject p3 = new PhysicsObject(60.0, 60.0, Shape.Circle);
            p3.Y = p1.Y + 50 + 30;
            p3.Color = new Color(173, 255, 47, 50);
            Add(p3);

            PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
            Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
}

