package DIO;

import java.util.*;

public class StudentG 
{
	static List slist = new ArrayList();
	
	private String name="";
	private String id="";

	public StudentG() {}; 
	public StudentG(String name,String id) 
	{
		this.name = name;
		this.id  = id;
	};
	
	public void AddStudent()
	{
        slist.add(this);
	}
	
	public int IdToIndex(String W)
	{
		for (int i = 0; i < slist.size();i++)
		{
			StudentG t = (StudentG)slist.get(i);
			if ( t.id.equals(W)) return i;
		}
		return -1;
	}

	public void DeleteSutedent(int x)
	{
		slist.remove(x);
	}
	
	public void ModifyStudent(int z,StudentG r)
	{
		slist.set(z,r);
	}
	
	public void ShowStudent(int i)
	{	
		StudentG t = (StudentG)slist.get(i);
		System.out.println("name: " + t.name + "  id: " + t.id);
	}
	
	public void ShowAll()
	{	
		for (int i = 0; i < slist.size();i++)
		{
			StudentG t = (StudentG)slist.get(i);
			System.out.println("name: " + t.name + "  id: " + t.id);
		}
	}
	
}
