using System;

public static class ElevatorEvents 
{
	public static Action<Floor> OnElevatorRequested;
	public static Action<Floor> OnElevatorArrivedToFloor;
	public static Action OnElevatorCallToRandomFloorRequested;
}
