using Godot;
using System;

public class StaticBody : Godot.StaticBody
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void _InputEvent(Node camera, InputEvent ev, Vector3 clickPosition, Vector3 clickNormal, int shapeIndex) {
        GD.Print($"Got input event {ev.AsText()}");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        
    }
}
