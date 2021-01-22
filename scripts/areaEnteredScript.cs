using Godot;
using System;

public class areaEnteredScript : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
     
 }

 public void areaEntered(Node body)
 {
     if (body.Name=="player")   // if the name of the node collided is player only
     {
         GD.Print("collided");  
         GetTree().ChangeScene("res://Assets/sceneAssets/GameOverUI.tscn");
     }
 }
}
