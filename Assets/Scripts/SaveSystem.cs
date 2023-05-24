using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

	public static void SavePlayerData ()
	{

		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.info";
		FileStream stream = new FileStream(path, FileMode.Create);

		buyandequip data = new buyandequip();

		formatter.Serialize(stream, data);
		stream.Close();

	}

	public static buyandequip LoadBuyandEquip ()
	{

		string path = Application.persistentDataPath + "/player.info";
		if(File.Exists(path))
		{
		    BinaryFormatter formatter = new BinaryFormatter();
		    FileStream stream = new FileStream(path, FileMode.Open);

		    buyandequip data = formatter.Deserialize(stream) as buyandequip;
		    stream.Close();

		    return data;


		} else
		{
		    Debug.LogError("save file not found in " + path);
		    
		    return null;

		}

	}
}
