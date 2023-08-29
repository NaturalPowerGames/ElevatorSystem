using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ElevatorController : MonoBehaviour
{
	public Floor CurrentFloor => currentFloor;
	private Floor currentFloor;
	public int AssignedSlot => assignedSlot;
	private int assignedSlot;
	public void GoToFloor(Floor floor)
	{
		transform.DOMove(floor.Location, 2).OnComplete(()=>
		{
			ElevatorEvents.OnElevatorArrivedToFloor?.Invoke(floor);
		});
	}
}
