using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{
	public int ElevatorSlots => elevatorSlots;
	private int elevatorSlots;
	public List<Floor> Floors => floors;
	private List<Floor> floors;
	
	public void AddFloor(Floor floor)
	{
		floors.Add(floor);
	}
}
