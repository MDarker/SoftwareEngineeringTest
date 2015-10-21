package p1;

import java.util.ArrayList;
import java.util.Scanner;

public class StuManagement {
	
	Student stu = new Student();
	public void DisPlay(){
		
		stu.addStu("100","chen");
		stu.addStu("104","cheng");
		stu.addStu("113","lin");
		
		System.out.println("****ѧ������ϵͳ****");
		System.out.println("������ţ�ѡ���Ӧ�Ĺ��ܣ�");
		System.out.println("1.�鿴����ѧ����Ϣ");
		System.out.println("2.��ѯһ��ѧ����Ϣ");
		System.out.println("3.���һ��ѧ����Ϣ");
		System.out.println("4.ɾ��һ��ѧ����Ϣ");
		System.out.println("5.�޸�һ��ѧ����Ϣ");
		System.out.println("0.�˳�");
	}
	
	public boolean Choice(){
		boolean flag = true;
		DisPlay();
		Scanner inChoice = new Scanner(System.in);	
		int choice = inChoice.nextInt();
			
		switch(choice){
		case 1://1.�鿴����ѧ����Ϣ
			System.out.println("---�鿴����ѧ����Ϣ---");
			showAllStu();
			break;
		case 2://2.��ѯһ��ѧ����Ϣ
			System.out.println("---��ѯһ��ѧ����Ϣ---");
			queryStu();
			break;
		case 3://3.���һ��ѧ����Ϣ
			System.out.println("---���һ��ѧ����Ϣ---");
			addStu();
			break;
		case 4://4.ɾ��һ��ѧ����Ϣ
			System.out.println("---ɾ��һ��ѧ����Ϣ---");
			deleteStu();
			break;
		case 5://5.�޸�һ��ѧ����Ϣ
			System.out.println("---�޸�һ��ѧ����Ϣ---");
			modifyStu();
			break;
		case 0:
			System.out.println("�˳�");
			flag = false;
			break;
		}
		inChoice.close();
		return true;
	}
	
	//�鿴����ѧ����Ϣ
	public void showAllStu(){
		ArrayList<Student> stus = new ArrayList<Student>();
		stus=stu.queryAllStu();
		for(int i = 0; i < stus.size(); i++){
			System.out.println(stus.get(i).getStuId()+"  "+stus.get(i).getStuName());
		}
	}
	
	//��ѯһ��ѧ����Ϣ
	public void queryStu(){
		System.out.println("����Ҫ��ѯѧ����ѧ�ţ�");
		Scanner inQueryId = new Scanner(System.in);
		String queryId = inQueryId.nextLine();
		Student s = stu.queryStu(queryId);
		if(s!=null){
			System.out.println(s.getStuId()+"  "+s.getStuName());
		}
		else{
			System.out.println("ѧ�������ڣ�");
		}
		inQueryId.close();
	}
	
	//���һ��ѧ����Ϣ
	public void addStu(){
		Scanner inStu = new Scanner(System.in);
		System.out.print("����Ҫ��ӵ�ѧ��ѧ�ţ�");
		String stuId = inStu.nextLine();
		System.out.print("����Ҫ��ӵ�ѧ��������");
		String stuName = inStu.nextLine();
		if(stu.addStu(stuId, stuName)){
			System.out.println("����ɹ���");
		}
		else{
			System.out.println("����ʧ�ܣ�");
		}
		inStu.close();
	}
	
	//ɾ��һ��ѧ����Ϣ
	public void deleteStu(){
		System.out.println("����Ҫɾ����ѧ��ѧ�ţ�");
		Scanner inDelId = new Scanner(System.in);
		String delId = inDelId.nextLine();
		if(stu.deleteStu(delId)){
			System.out.println("ɾ���ɹ���");
		}
		else{
			System.out.println("ɾ��ʧ�ܣ�");
		}
		inDelId.close();
	}
	
	//�޸�һ��ѧ����Ϣ
	public void modifyStu(){
		System.out.println("����Ҫ�޸ĵ�ѧ��ѧ�ţ�");
		Scanner inModifyId = new Scanner(System.in);
		String modifyId = inModifyId.nextLine();
		stu.modifyStu(modifyId);
		inModifyId.close();
	}
}