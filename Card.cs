using Godot;
using System;

public class Card : Spatial
{
    public override void _Ready()
    {

    }

    public override void _Process(float delta)
    {
        RotateY(delta * -2);
    }
}
