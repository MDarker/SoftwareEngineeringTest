package DIO;

import java.util.Scanner;

public class SPW 
{
	public static void main(String[] args)
	{
		System.out.println("��ӭʹ��ѧ��ϵͳ��");
		while (true)
		{
			System.out.println("0.����ѧ����Ϣ");
			System.out.println("1.ɾ��ѧ����Ϣ");
			System.out.println("2.�޸�ѧ����Ϣ");
			System.out.println("3.��ѯָ��ѧ����Ϣ");
			System.out.println("4.�������ѧ����Ϣ");
			System.out.println("5.�˳�");
			
			Scanner input = new Scanner (System.in);
			String x = input.next();
			char t = x.charAt(0);
			switch (t)
			{
			     case '0': 
			
					System.out.println("������ѧ��������");
					String a = input.next();  
					
			    	System.out.println("������ѧ��ѧ�ţ�");	
			        String b = input.next(); 
					
			        StudentG A = new StudentG(a,b);
			        A.AddStudent();
			    	System.out.println("��ӳɹ���");	
			     break;
			     case '1':
					 System.out.println("��������Ҫɾ����ѧ��ѧ�ţ�");	
					 String c = input.next();
			    	 StudentG D = new StudentG();	
			    	 
			    	 if (D.IdToIndex(c) != -1)  
		     	     {
			    		 D.DeleteSutedent(D.IdToIndex(c));
						 System.out.println("ɾ���ɹ���");	    		 
			    	 }
			    	 else System.out.println("���޴��ˣ�");	
			     break;
			     case '2': 
			    	 StudentG M = new StudentG();
					 System.out.println("��������Ҫ�޸ĵ�ѧ��ѧ�ţ�");	
					 String d = input.next();
					 if (M.IdToIndex(d) != -1 ) 
					 {
						 System.out.println("�������޸ĺ��ѧ��������");	
						 String e = input.next();
						 System.out.println("�������޸ĺ��ѧ��ѧ�ţ�");	
						 String f = input.next();
						 StudentG N = new StudentG(e,f);
						 
				     	 M.ModifyStudent(M.IdToIndex(d),N);
						 System.out.println("�޸ĳɹ���");					     	 
					 }
	                 else System.out.println("���޴��ˣ�");	
			     break;
			     case '3':
					 System.out.println("�������ѯ��ѧ��ѧ�ţ�");
					 String g = input.next();					 
			    	 StudentG S = new StudentG();
			         if (S.IdToIndex(g) != -1 ) S.ShowStudent(S.IdToIndex(g));
			         else System.out.println("���޴��ˣ�");	
			     break;
			     case '4': StudentG SA = new StudentG();
			     SA.ShowAll();
			     break;
			     default : return ; 
			}
		}
	}
}
