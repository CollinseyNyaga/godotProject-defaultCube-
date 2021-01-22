using Godot;
using System;

public class loadLevelScene : Control
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }

    // this method is used to load the level scene after the user presses the retry level button.
    // the method is called after the signal is emitted [button pressed signal] 

    public void onRetryPressed()
    {
        GetTree().ChangeScene("res://scenes/level1.tscn"); // gets the scene tree and changes the scene to level1 scene.


    }

}
