using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class itemdatabase : MonoBehaviour {
	public List <Item> items = new List<Item>();

	void awake(){
		items.Add (new Item ("buut",0,"so op", 2, 0, Item.ItemType.weapon)); 
		items.Add (new Item ("J", 1,"this is a big jj" ,0,0, Item.ItemType.weapon));
	}
}
