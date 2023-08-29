using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestUIController : MonoBehaviour
{
	public TextMeshProUGUI reportText;
	public Button callElevatorToRandomFloorButton;
	
	// Awake is called when the script instance is being loaded.
	protected void Awake()
	{
		callElevatorToRandomFloorButton.onClick.AddListener(()=>
		{
			ElevatorEvents.OnElevatorCallToRandomFloorRequested?.Invoke();
		});
	}
    
}
