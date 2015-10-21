package DIO;

import java.util.Scanner;

public class SPW 
{
	public static void main(String[] args)
	{
		System.out.println("欢迎使用学生系统！");
		while (true)
		{
			System.out.println("0.增加学生信息");
			System.out.println("1.删除学生信息");
			System.out.println("2.修改学生信息");
			System.out.println("3.查询指定学生信息");
			System.out.println("4.浏览所有学生信息");
			System.out.println("5.退出");
			
			Scanner input = new Scanner (System.in);
			String x = input.next();
			char t = x.charAt(0);
			switch (t)
			{
			     case '0': 
			
					System.out.println("请输入学生姓名：");
					String a = input.next();  
					
			    	System.out.println("请输入学生学号：");	
			        String b = input.next(); 
					
			        StudentG A = new StudentG(a,b);
			        A.AddStudent();
			    	System.out.println("添加成功！");	
			     break;
			     case '1':
					 System.out.println("请输入需要删除的学生学号：");	
					 String c = input.next();
			    	 StudentG D = new StudentG();	
			    	 
			    	 if (D.IdToIndex(c) != -1)  
		     	     {
			    		 D.DeleteSutedent(D.IdToIndex(c));
						 System.out.println("删除成功！");	    		 
			    	 }
			    	 else System.out.println("查无此人！");	
			     break;
			     case '2': 
			    	 StudentG M = new StudentG();
					 System.out.println("请输入需要修改的学生学号：");	
					 String d = input.next();
					 if (M.IdToIndex(d) != -1 ) 
					 {
						 System.out.println("请输入修改后的学生姓名：");	
						 String e = input.next();
						 System.out.println("请输入修改后的学生学号：");	
						 String f = input.next();
						 StudentG N = new StudentG(e,f);
						 
				     	 M.ModifyStudent(M.IdToIndex(d),N);
						 System.out.println("修改成功！");					     	 
					 }
	                 else System.out.println("查无此人！");	
			     break;
			     case '3':
					 System.out.println("请输入查询的学生学号：");
					 String g = input.next();					 
			    	 StudentG S = new StudentG();
			         if (S.IdToIndex(g) != -1 ) S.ShowStudent(S.IdToIndex(g));
			         else System.out.println("查无此人！");	
			     break;
			     case '4': StudentG SA = new StudentG();
			     SA.ShowAll();
			     break;
			     default : return ; 
			}
		}
	}
}
