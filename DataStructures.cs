using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationNetCore2Vs3
{
	public class Thing
	{
		public Thing()
		{
			Items=new List<Item>();
		}

		public List<Item> Items { get; set; }
	}

	public class Item
	{
		public Item()
		{
			SubItems = new List<SubItem>();
		}

		public List<SubItem> SubItems { get; }
	}

	public class SubItem
	{
	}
}
