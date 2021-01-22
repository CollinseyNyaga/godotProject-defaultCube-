using Godot;
using System;

public class playerCharacter : KinematicBody
{
    // the following are global scoped variables of this class 
    [Export] int gravity = 10; // this is the gravity for the character.Is accesible to the godot editor
    Vector3 GravityVelocity;           // this will be used as an argument in the moveandslide method of the kinematicbody to add gravity only


    Vector3 ForwardVelocity;    // this is the argument for the forward moveandslide method only
    [Export] public int speed = 20;    // this is the speed of the kinematic body

    Vector3 sideWaysVelocity = new Vector3(0, 0, 0);







    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
       
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }

    // the method is run 60 times per second 
    public override void _PhysicsProcess(float delta)
    {
        // GravityMethod();
        MoveForward();
        PlayerInput();
    }

    // end of the overridable functions



    // start of custom functions
    public void GravityMethod() // this method is used to add gravity force on the y axis of the kinematic body
    {

        // initialize the force of gravity on the y axis of the vector3 
        GravityVelocity.y = -gravity;

        MoveAndSlide(GravityVelocity);  // move and slide method that takes the gravityvelocity as argument
        System.Console.WriteLine(GlobalTransform);
    } // end of the method 



    public void MoveForward()   // this method is used to move the kinematic body along the z axis forwards
    {
        ForwardVelocity.z = -speed;
        MoveAndSlide(ForwardVelocity);  // this method makes the cube to move on the z axis without stopping 
    } // end of the method 


    public void PlayerInput()
    {
        sideWaysVelocity.x = 35;  //sets the velocity of the sideways movement to 20


        if (Input.IsActionPressed("slideLeft"))
        {
            sideWaysVelocity.x = -sideWaysVelocity.x;
            GD.Print("left");
            MoveAndSlide(sideWaysVelocity);
        }
        if (Input.IsActionPressed("slideRight"))
        {
            GD.Print("right");
            MoveAndSlide(sideWaysVelocity);
        }

    } // end of the method 







}// end of teh class 
