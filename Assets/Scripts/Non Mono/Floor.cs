using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor 
{
	private List<Apartment> apartments;
	public List<Apartment> Apartments => apartments;
	public Vector3 Location => location;
	private Vector3 location;
	private int slots;
	public int Slots => slots;
	private bool[] slotOccupation;
	public bool[] SlotOccupation => slotOccupation;
	
	public void SetSlotAsOccupied(int slot)
	{
		slotOccupation[slot] = true;
	}
}
