using System;
using System.Collections.Generic;

namespace SerializationNetCore2Vs3
{
	class Program
	{
		private static Item CreateItem()
		{
			var item = new Item();
			item.SubItems.Add(new SubItem());
			item.SubItems.Add(new SubItem());
			item.SubItems.Add(new SubItem());
			item.SubItems.Add(new SubItem());
			return item;
		}
		static void Main(string[] args)
		{
			var original = new Thing();
			original.Items.Add(CreateItem());
			original.Items.Add(CreateItem());


			var json = System.Text.Json.JsonSerializer.Serialize(original);
			var json2 = Newtonsoft.Json.JsonConvert.SerializeObject(original);
			Console.WriteLine($"JSON is equal: {String.Equals(json, json2, StringComparison.Ordinal)}");
			Console.WriteLine();

			var instance1 = System.Text.Json.JsonSerializer.Deserialize<Thing>(json);
			var instance2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Thing>(json);

			Console.WriteLine($".Items.Count: {instance1.Items.Count} (System.Text.Json)");
			Console.WriteLine($".Items.Count: {instance2.Items.Count} (Json.NET)");
			Console.WriteLine();
			Console.WriteLine($".Items[0].SubItems.Count: {instance1.Items[0].SubItems.Count} (System.Text.Json)");
			Console.WriteLine($".Items[0].SubItems.Count: {instance2.Items[0].SubItems.Count} (Json.NET)");
		}
	}
}
