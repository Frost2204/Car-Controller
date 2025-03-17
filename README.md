🚗 Car Controller for Unity
This project contains a CarController script that allows you to drive a car in Unity using realistic physics. The script controls acceleration, braking, and steering, using Unity's Wheel Colliders for smooth vehicle movement.

![Car Preview](https://i.imgur.com/4wjZkqR.gif)

📌 Features
Smooth Acceleration & Braking – Uses motorTorque for acceleration and brakeTorque for braking.
Realistic Steering – Implements wheel rotation with a maximum steering angle.
Wheel Animations – Updates wheel positions and rotations dynamically.
Customizable Settings – Easily adjust motor power, braking force, and steering angle.

🛠️ Setup & Usage
1️⃣ Add the Script
  Create an Empty GameObject in Unity and name it "Car".
  Attach a Rigidbody component to the Car.
  Add the CarController.cs script to the Car GameObject.
2️⃣ Assign Wheel Colliders & Transforms
  Create 4 Wheel Colliders (Front Left, Front Right, Rear Left, Rear Right).
  Assign them in the Inspector under the CarController component.
  Attach wheel meshes (Transforms) to update their position and rotation.
3️⃣ Configure Input Controls
  Action	Input
  Accelerate	W or Up Arrow
  Brake	Space
  Steer Left	A or Left Arrow
  Steer Right	D or Right Arrow

🎮 Script Overview
  🔹 Variables
    motorForce → Controls how much power is applied to the wheels.
    brakeForce → Determines how strong the brakes are.
    maxSteerAngle → Sets the maximum turning angle.
  🔹 Main Methods
    GetInput() → Reads player input for steering, acceleration, and braking.
    HandleMotor() → Applies motor torque and braking force.
    HandleSteering() → Rotates the front wheels for turning.
    UpdateWheels() → Updates the wheel transforms to match physics.
    
📜 License
This project is open-source and free to use.

Car Model by Polyeler!
