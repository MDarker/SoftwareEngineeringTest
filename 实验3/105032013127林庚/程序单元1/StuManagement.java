package p1;

import java.util.ArrayList;
import java.util.Scanner;

public class StuManagement {
	
	Student stu = new Student();
	public void DisPlay(){
		
		stu.addStu("100","chen");
		stu.addStu("104","cheng");
		stu.addStu("113","lin");
		
		System.out.println("****学生管理系统****");
		System.out.println("输入序号，选择对应的功能：");
		System.out.println("1.查看所有学生信息");
		System.out.println("2.查询一个学生信息");
		System.out.println("3.添加一个学生信息");
		System.out.println("4.删除一个学生信息");
		System.out.println("5.修改一个学生信息");
		System.out.println("0.退出");
	}
	
	public boolean Choice(){
		boolean flag = true;
		DisPlay();
		Scanner inChoice = new Scanner(System.in);	
		int choice = inChoice.nextInt();
			
		switch(choice){
		case 1://1.查看所有学生信息
			System.out.println("---查看所有学生信息---");
			showAllStu();
			break;
		case 2://2.查询一个学生信息
			System.out.println("---查询一个学生信息---");
			queryStu();
			break;
		case 3://3.添加一个学生信息
			System.out.println("---添加一个学生信息---");
			addStu();
			break;
		case 4://4.删除一个学生信息
			System.out.println("---删除一个学生信息---");
			deleteStu();
			break;
		case 5://5.修改一个学生信息
			System.out.println("---修改一个学生信息---");
			modifyStu();
			break;
		case 0:
			System.out.println("退出");
			flag = false;
			break;
		}
		inChoice.close();
		return true;
	}
	
	//查看所有学生信息
	public void showAllStu(){
		ArrayList<Student> stus = new ArrayList<Student>();
		stus=stu.queryAllStu();
		for(int i = 0; i < stus.size(); i++){
			System.out.println(stus.get(i).getStuId()+"  "+stus.get(i).getStuName());
		}
	}
	
	//查询一个学生信息
	public void queryStu(){
		System.out.println("输入要查询学生的学号：");
		Scanner inQueryId = new Scanner(System.in);
		String queryId = inQueryId.nextLine();
		Student s = stu.queryStu(queryId);
		if(s!=null){
			System.out.println(s.getStuId()+"  "+s.getStuName());
		}
		else{
			System.out.println("学生不存在！");
		}
		inQueryId.close();
	}
	
	//添加一个学生信息
	public void addStu(){
		Scanner inStu = new Scanner(System.in);
		System.out.print("输入要添加的学生学号：");
		String stuId = inStu.nextLine();
		System.out.print("输入要添加的学生姓名：");
		String stuName = inStu.nextLine();
		if(stu.addStu(stuId, stuName)){
			System.out.println("插入成功！");
		}
		else{
			System.out.println("插入失败！");
		}
		inStu.close();
	}
	
	//删除一个学生信息
	public void deleteStu(){
		System.out.println("输入要删除的学生学号：");
		Scanner inDelId = new Scanner(System.in);
		String delId = inDelId.nextLine();
		if(stu.deleteStu(delId)){
			System.out.println("删除成功！");
		}
		else{
			System.out.println("删除失败！");
		}
		inDelId.close();
	}
	
	//修改一个学生信息
	public void modifyStu(){
		System.out.println("输入要修改的学生学号：");
		Scanner inModifyId = new Scanner(System.in);
		String modifyId = inModifyId.nextLine();
		stu.modifyStu(modifyId);
		inModifyId.close();
	}
}