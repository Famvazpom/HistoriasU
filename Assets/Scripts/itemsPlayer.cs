using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsPlayer : MonoBehaviour {

	private Dictionary<string,bool> items = null;

	void Start()
	{
		items = new Dictionary<string,bool>();
		items.Add("Key",false);
		items.Add("Nota1",false);
		items.Add("Nota2",false);
		items.Add("Nota3",false);
		items.Add("Nota4",false);
	}

	public void GetItem(string item)
	{
		items[item] = true;
		Debug.Log(item);
	}

	public bool CheckItem(string item)
	{
		
		if(items.ContainsKey(item))
		{
			return items[item];
		}
		return false;
	}

	public bool CheckNotes()
	{

		if(items["Nota1"] && items["Nota2"] && items["Nota3"] && items["Nota4"])
		{
			return true;
		}
		return false;
	}

	public int getNotes()
	{
		int count = 0;
		foreach (var item in items)
		{
			if(item.Key != "Key" && item.Value)
			{
				count+=1;
			}
		}
		return count;
	}

	public bool hasAll()
	{
		foreach (var item in items)
		{
			if(!item.Value)
			{
				return false;
			}
		}
		return true;
	}

}
