using Godot;
using System;

public class HUDPlayer : Control
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.

    int finalScoreValue;
    Label scoreValue;
    Spatial scoreSystemNode;


    public override void _Ready()
    {
        scoreValue = GetNode<Label>("centercont/Label");    //gets the label that will display the score on the hud

        // getting the scoreSystem node in the level scene which calculates the score
        scoreSystemNode = GetTree().Root.GetNode("level1").GetNode<Spatial>("ScoreSystem");


    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        changeTheScore(delta);  // changes the score by passing an argument to the method 
    }

    public void changeTheScore(float valueOfScore)
    {
        // get the value of the score variable in the scoresystemnode .\
        finalScoreValue = (int)scoreSystemNode.Get(property: "score");

        // set the value of the label text to the value that has been gotten from the other node above
        scoreValue.Set(property: "text", value: Convert.ToString(finalScoreValue));
    }

   
}
