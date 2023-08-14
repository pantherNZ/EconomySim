using System.Collections.Generic;

public class DataManager
{
    private static DataManager _Instance = new DataManager();
    public static DataManager Instance
    {
        get { return _Instance; }
        private set { }
    }

    public List<Element> elements = new List<Element>();
    public List<Recipe> recipes = new List<Recipe>();
}