using Godot;
using System;

public class gameplayColliders : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.

    SceneTree currentTree;

    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }

    public void speed1Entered(Node body)
    {
        if (body.Name == "player")                          // if the name of the collided body is equal to player .
        {
            var player = GetParent().GetNode("player");     // get the parent of the current node and get a node of the name player and store it in a var player.
            player.Set(property: "speed", value: 40);       // this line here sets the speed of the player node to a certain value. [using the key:value pair syntax]
        }
    }
    public void speed2Entered(Node body)
    {
        if (body.Name == "player")                          // if the name of the collided body is equal to player .
        {
            var player = GetParent().GetNode("player");     // get the parent of the current node and get a node of the name player and store it in a var player.
            player.Set(property: "speed", value: 55);       // this line here sets the speed of the player node to a certain value. [using the key:value pair syntax]

        }
    }
    public void finishLineEntered(Node body)
    {
        if (body.Name == "player")
        {
            var levelCompleteUI = GetParent().GetNode("UserInterface").GetNode("LevelComplete");     // get the parent of the current node and get a node of the name player and store it in a var player.
            levelCompleteUI.Call(method:"showTheUI");      // this line here calls a method of the node and it gets executed
        }
    }
}
