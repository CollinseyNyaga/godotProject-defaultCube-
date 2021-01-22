using Godot;
using System;

public class CameraFollow : Camera
{


    Spatial cameraPoint;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        cameraPoint = GetParent().GetNode<Spatial>("player/camerafollow");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {




    }


    public override void _PhysicsProcess(float delta)
    {
        followCamera();
    }
    // end of overridable functions




    ///////start of custom functions 
    public void followCamera()
    {
        this.GlobalTransform = cameraPoint.GlobalTransform;

    }



}
