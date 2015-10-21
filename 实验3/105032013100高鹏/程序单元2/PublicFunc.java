package publicFunc;
import java.util.*;

import stuFunc.StuAttribute;
import stuFunc.StuFunc;

/**
 *学生管理系统的公共类
 * @author f
 * 
 */

//学生管理系统的基本功能类
public class PublicFunc {
	StuFunc stu = new StuFunc();//定义一个学生功能类对象
	Scanner input = new Scanner(System.in);//定义一个输入的扫描器
	
	//构造函数
	public PublicFunc() {
		super();
		stu.ReadStuInfo();//读入文件中的数据
	}

	//菜单顶部标语
	public void ShowMenuTop (){
		System.out.println("-----------学生管理系统----------");
	}

	//底部菜单标语
	public void ShowMenuFoot (){
		System.out.println("--------欢迎使用学生管理系统--------------");
	}

	//菜单列表
	public void ShowMainMenu (){
		System.out.println("\t1.显示所有学生信息\n");
		System.out.println("\t2.添加学生信息\n");
		System.out.println("\t3.删除学生信息\n");
		System.out.println("\t4.修改学生信息\n");
		System.out.println("\t5.查询学生信息\n");
		System.out.println("\t6.保存学生信息\n");
		System.out.println("\t7.退出学生管理系统\n");
	}

	//关闭扫描器
	public void EndScanner(){
		input.close();
	}
	
	//系统结束语
	public void ShowMenuEnd (){
		System.out.println("-----------谢谢使用学生管理系统--------------");
	}
	
	//重复操作选择
	public boolean ConOp(){		
		while(true){
			try{
				System.out.println("按1继续操作 否则退出");
				input.nextLine();
				String temp = input.nextLine();
				if(temp.compareTo("1") == 0)
				return true;//返回true外层循环继续循环
				return false;//返回false外层循环结束循环退出程序
			}catch(Exception e){
				return false;
			}
		}
	}
	
	//功能序号选择———输入功能
	public int FunNo(){
		try{
		System.out.println("请输入您所需功能的序号");
		int i = input.nextInt();
		return i;//返回相应的功能序号
		}catch(Exception e){
			System.out.println("输入格式有误请重新输入");
			return -1;//返回非正数外层循环继续循环执行
		}
	}

	//输入学生人数
	public int StuNo(){
		try{
		System.out.println("请输入要录入的学生数");
		int num = input.nextInt();
		input.nextLine();
		return num;
		}catch(Exception e){
			System.out.println("输入格式有误请重新输入");
			return -1;//返回非正数外层循环继续循环执行
		}
	}
	
	//输出要删除/修改/查找的学生学号
	//根据传人不同的参数选择相应的输出文字
	public String StuID(int fun){
		try{
		if(fun == 0)
			System.out.println("输入要删除的学生学号");
		else if(fun == 1)
			System.out.println("输入要修改的学生学号");
		else 
			System.out.println("输入要查找的学生学号");
		String num = input.nextLine();
		return num;//返回学生学号
		}catch(Exception e){
			System.out.println("输入格式错误");
			return null;//返回null使得外层循环继续循环执行StuID
		}
	}
	
	//输入个人学生信息
	public StuAttribute InputStu(int i,boolean fun){
		while(true){
			if(i>0)
				System.out.println("请输入第"+(i+1)+"个学生的姓名，学号，性别，班级，年级信息:");
			else
				System.out.println("请输入学生的姓名，学号，性别，班级，年级信息:\n\t\t[XXX,105XXXXX,男，2,2013]");
			try{
				String stuName = input.nextLine();
				String stuNo = input.nextLine();
				String stuGender = input.nextLine();
				String stuClass = input.nextLine();
				String stuGrade = input.nextLine();
				StuAttribute sA = new StuAttribute(stuName, stuNo, stuGender, stuClass, stuGrade);
				return sA;//返回个人学生信息对象
			}catch(Exception ex){
				System.out.println("输入格式有误");
				continue;//在本函数循环，保证返回值得合法性
			}
		}
	}
	
	//学生管理系统功能选择函数
	public boolean StuFuncChoice(){
		try{
			boolean temp;
			int choiceNO;
			choiceNO = FunNo();
			switch (choiceNO){
			case 1://显示所有学生信息
				stu.ShowStuInfo();
				temp = ConOp();//提示是否再续操作
				if(temp)
				return true;//返回true可重复操作
				break;
			case 2://添加学生信息
				stu.AddStu();
				stu.SaveStuInfo();
				temp = ConOp();//提示是否再续操作
				if(temp)
				return true;//返回true可重复操作
				break;
			case 3://删除学生信息
				stu.delStuInfo();
				temp = ConOp();//提示是否再续操作
				if(temp)
				return true;//返回true可重复操作
				break;
			case 4://修改学生信息
				stu.ModifyStuInfo();
				temp = ConOp();//提示是否再续操作
				if(temp)
				return true;//返回true可重复操作
				break;
			case 5://查询学生信息
				stu.SeekStuInfo();
				temp = ConOp();//提示是否再续操作
				if(temp)
				return true;//返回true可重复操作
				break;
			case 6://保存学生信息
				stu.SaveStuInfo();
				temp = ConOp();//提示是否再续操作
				if(temp)
				return true;//返回true可重复操作
				break;
			case 7://退出学生管理系统
				ShowMenuEnd();//显示结束语
				System.exit(0); //退出程序
				stu.closedFile();//关闭开启的文件流
				break;
			default:
				System.out.println("输入序号有误！！！");
				return true;//返回true外层循环会循环执行本函数
			}
		}
		//输入非法处理
		catch (Exception ex){
			System.out.println("输入格式有误！！！");
			return true;
		}
		return false;
	}	
}
