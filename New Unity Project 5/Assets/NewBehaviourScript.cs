using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {
	public int slotsX, SlotsY;
	public GUISkin skin;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item>();
	private bool showInventory;
	private itemdatabase database;
	private bool showTooltip;
	private string tooltip;

	void start () {
		for(int i = 0; i < (slotsX * SlotsY);i++){
			slots.Add(new Item());
			inventory.Add (new Item());
		}
		database = GameObject.FindGameObjectWithTag ("Item database").GetComponent<itemdatabase> ();
		AddItem (1);
		AddItem (0);

		print (InventoryContains(4));
	}
	void Update(){
		if (Input.GetButtonDown ("Inventory")) {
			showInventory = !showInventory;
		}
	}

	void OnGUI () {
		tooltip = "";
		GUI.skin = skin;
		if(showInventory){
			DrawInventory();
		}
		if (showTooltip) {
			GUI.Box( new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, 200, 200), tooltip);
		}
	}

	void DrawInventory(){
		int i = 0;
		for(int x = 0; x < slotsX; x++){
			for(int y = 0; y < SlotsY; y++){
				Rect slotRect = new Rect(x * 60, y * 60, 50, 50);
				GUI.Box (slotRect, "", skin.GetStyle ("Slot"));
				if((x+(y*slotsX)) < inventory.Count){
					slots[x+(y*slotsX)] = inventory[x+(y*slotsX)];
					GUI.DrawTexture(slotRect, slots[x+(y*slotsX)].itemIcon);
					if(slotRect.Contains(Event.current.mousePosition)){
						tooltip = CreatTooltip(slots[i]);
						showTooltip = true;
					}
				}
				if( tooltip == ""){
					showTooltip = false;
				}
				i++;
			}
		}
	}

	string CreatTooltip(Item item){
		tooltip = item.itemName;
		return tooltip;

	}
	void RemoveItem(int id){
		for (int i =0; i< inventory.Count; i++) {
			if(inventory[i].itemID == id){
				inventory[i] = new Item();
				break;
			}
		}
	}
	void AddItem(int id){
		for (int i = 0; i< inventory.Count; i++) {
			if(inventory[i].itemName == null){
				for(int j =0; j < database.items.Count; j++){
					if(database.items[j].itemID == id){
						inventory[i] = database.items[j];
					}
				}
				break;
			}
		}
	}
	bool InventoryContains(int id){
		bool result = false;
		for (int i =0; i< inventory.Count; i++) {
			result = inventory[i].itemID == id;
			if(result){
				break;
			}
		}
		return result;
	}
}












