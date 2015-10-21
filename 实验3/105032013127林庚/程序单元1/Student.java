package p1;

import java.util.ArrayList;
import java.util.Scanner;

public class Student {
	private String stuName;
	private String stuId;
	
	public String getStuName(){
		return this.stuName;
	}
	public void setStuName(String stuName){
		this.stuName = stuName;
	}
	public String getStuId(){
		return this.stuId;
	}
	public void setStuId(String stuId){
		this.stuId = stuId;
	}
	private ArrayList<Student> students = new ArrayList<Student>();
	
	public Student queryStu(String stuId){
		for(int i = 0; i < students.size(); i++){
			if(students.get(i).getStuId().equals(stuId)){
				return students.get(i);
			}
		}
		return null;
	}
	
	public ArrayList<Student> queryAllStu(){
		return students;
	}
	
	public boolean addStu(String stuId,String stuName){
		Student stu = new Student();
		stu.setStuId(stuId);
		stu.setStuName(stuName);
		if(this.addStu(stu)){
			return true;
		}
		else{
			return false;
		}
	}
	public boolean addStu(Student stu){
		if(students.add(stu)){
			return true;
		}
		else{
			return false;
		}
	}
	
	public boolean deleteStu(String stuId){
		for(int i = 0; i < students.size(); i++){
			if(students.get(i).getStuId().equals(stuId)){
				students.remove(i);
				return true;
			}
		}
		return false;
	}
	
	public void modifyStu(String stuOldId){
		Student stu = queryStu(stuOldId);
		Scanner inStu = new Scanner(System.in);
		System.out.print("学号改为:");
		String stuNewId = inStu.nextLine();
		System.out.print("姓名改为:");
		String stuNewName = inStu.nextLine();
		
		stu.setStuId(stuNewId);
		stu.setStuName(stuNewName);
	}
}
