using Godot;
using System;

public class Main : Spatial
{

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var i = 0;
        var textures = new string[] {"BmarksmanL", "Bmonk", "Rpeasant"};

        foreach (var card in new string[] {"Card1", "Card2", "Card3"})
        {
            var mi = GetNode<MeshInstance>($"{card}/StaticBody/MeshInstance");
            mi.Mesh = mi.Mesh.Duplicate() as Mesh;

            var mat = mi.Mesh.SurfaceGetMaterial(0).Duplicate() as SpatialMaterial;
            var tex = textures[i++];
            mat.AlbedoTexture = ResourceLoader.Load($"res://Cards/{tex}.png") as Texture;
            mi.MaterialOverride = mat;
        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
