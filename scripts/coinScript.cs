
using Godot;
using System;

public class coinScript : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.

    // the score system node to call the coin collected method in the scoresystem node to add score value when a coin is collected
    Spatial scoreSystem;

    public override void _Ready()
    {
        scoreSystem = GetTree().Root.GetNode("level1").GetNode<Spatial>("ScoreSystem");
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.

    // public override void _Process(float delta)
    // {
    //     
    // }

    public override void _PhysicsProcess(float delta)
    {
        coinRotate();
    }
    public void coinEntered(Node body)
    {
        if (body.Name == "player")
        {
            this.QueueFree();
            scoreSystem.Call("coinCollected");


            // when the coins body is entered, we want to play a coin collected sound 
            GetNode("coincollectSound").GetNode("audio").Call("play", (float)0);

        }
    }

    public void coinRotate()
    {
        this.RotateY((float)0.08);
    }
}
