using Godot;
using System;

public class Card : Spatial
{
    public override void _Ready()
    {

    }

    public void _InputEvent(Node camera, InputEvent ev, Vector3 clickPosition, Vector3 clickNormal, int shapeIndex)
    {
        var mouseEv = ev as InputEventMouseButton;
        if (mouseEv != null)
        {
            if (mouseEv.Pressed)
            {
                RotateY(2.0f * (float)Math.PI / 20.0f);
            }
        }
    }

    public override void _Process(float delta)
    {
        // RotateY(delta * -2);
    }
}
