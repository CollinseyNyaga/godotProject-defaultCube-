// this class is used to calculate the score and calls the HUDPlayer method to update the value of the label


using Godot;
using System;



public class ScoreSystem : Spatial
{

    int score = 0;
    int finalScore;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        setScore();

    }

    public void setScore()
    {
        score = Convert.ToInt32((score + 1));   // score is equal to current score plus one every frame multiplied by delta 
    }

    public void coinCollected()
    {
        score = score + 500;
    }

}
