﻿using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public Menu currentMenu;

	public void Start(){
		ShowMenu (currentMenu);
	}

	public void ShowMenu(Menu menu){
		if (currentMenu != null) {
			currentMenu.IsOpen = false;
		}

		currentMenu = menu;
		if(currentMenu != null)
			currentMenu.IsOpen = true;
	}

	public void OpenMenu(Menu menu){
		menu.IsOpen = true;
	}

	public void CloseMenu(Menu menu){
		menu.IsOpen = false;
	}
}
