﻿using UnityEngine;
using System.Collections;

public class InventoryGUI : GUIFrame {
	public static InventoryGUI singleton = null;
	public CharacterData charData = null;

	// Use this for initialization
	void Start () {
		hidden = true;
		if(singleton == null)
		{
			singleton = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OnGUI()
	{
		if(!hidden)
		{
			base.OnGUI();
			GUI.Label(new Rect(screenRect.x+10, screenRect.y, screenRect.width, 50), "Stats");
			GUI.Label (new Rect (screenRect.x+10, screenRect.y + 34, screenRect.width, 100), "Energy: " + charData.getEnergy());
			GUI.Label (new Rect (screenRect.x+10, screenRect.y + 20, screenRect.width, 100), "Health: " + charData.getHealth());

			if(Floor.currentFloor != null)
			{
				GUI.Label (new Rect (screenRect.x+10, screenRect.y + 50, screenRect.width, 100), "CurrentFloor: " + Floor.currentFloor.floorName);
			}
			if(Room.currentRoom != null)
			{
				GUI.Label (new Rect (screenRect.x+10, screenRect.y + 70, screenRect.width, 100), "CurrentRoom: " + Room.currentRoom.roomName);
			}
		}
	}
}
